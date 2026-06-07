using DISCPrinting.Application.Extensions;
using DISCPrinting.Domain.Extensions;
using DISCPrinting.Infrastructure.Extensions;
using DISCPrinting.WinUI.Forms;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using DISCPrinting.Infrastructure.Services;
using DISCPrinting.Infrastructure.Winform.Extensions;
using DISCPrinting.Infrastructure.Winform.Services;
using DISCPrinting.WinUI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Reflection;

namespace WinFormApp
{
    internal static class Program
    {
        public static IHost? AppHost { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            ApplicationConfiguration.Initialize();
            AppHost = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile(configPath, optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<IMessageFilter, ActivityMonitor>();
                services.AddSingleton<MainForm>();
                services.AddSingleton<LoginForm>();
                services.RegisterUserControls();
                services.AddDomainExtensions(context.Configuration);
                services.AddInfrastructureExtensions(context.Configuration);
                services.AddInfrastructureWinformExtensions(context.Configuration);
                services.AddApplicationExtensions(context.Configuration);
                
            })
            .Build();

            //  Catch errors on UI thread
            Application.ThreadException += (s, e) => RestartApp(e.Exception);

            // Catch errors on non-UI thread
            AppDomain.CurrentDomain.UnhandledException += (s, e) => RestartApp(e.ExceptionObject as Exception);

            Application.AddMessageFilter(AppHost.Services.GetRequiredService<IMessageFilter>());
            var timer = AppHost.Services.GetRequiredService<ITimerService>();
            timer.Start();

            Application.Run(AppHost.Services.GetRequiredService<MainForm>());
        }
        private static void RestartApp(Exception? ex)
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
            if (!Directory.Exists(logPath)) Directory.CreateDirectory(logPath);
            logPath = Path.Combine(logPath, $"log_{DateTime.Now.ToString("yyyy-MM-dd")}");
            File.AppendAllText(logPath, ex.Message + Environment.NewLine);
            File.AppendAllText(logPath, ex.StackTrace + Environment.NewLine);
            MessageBox.Show(ex.Message);
            var upTime = DateTime.Now - Process.GetCurrentProcess().StartTime;

            if (upTime.TotalSeconds < 10)
            {
                Application.Exit();
                Environment.Exit(0);
            }
            else
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
        private static IServiceCollection RegisterUserControls(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var userControlTypes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseUserControl)));

            foreach (var type in userControlTypes)
            {
                services.AddTransient(type);
            }

            return services;
        }
    }
}