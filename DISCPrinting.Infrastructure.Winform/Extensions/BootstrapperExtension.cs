using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Infrastructure.Services;
using DISCPrinting.Infrastructure.Winform.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.Infrastructure.Winform.Extensions;

public static class BootstrapperExtension
{
    public static IServiceCollection AddInfrastructureWinformExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IPrintService, PrintService>();
        services.AddScoped<ITimerService, TimerService>();
        services.AddScoped<IClientProvider, ClientProvider>();
        return services;
    }
}
