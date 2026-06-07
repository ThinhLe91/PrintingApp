using DISCPrinting.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI;

public partial class LoginForm : Form
{
    public LoginForm(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        var loginUC = serviceProvider.GetRequiredService<LoginUC>();
        loginUC.Dock = DockStyle.Fill;
        loginUC.LoginSuccessChange += LoginUC_LoginSuccessChange;
        MainPanel.Controls.Add(loginUC);
        SetVersion();
    }

    private void LoginUC_LoginSuccessChange()
    {
        this.DialogResult = DialogResult.OK;
    }

    private void SetVersion()
    {
        var clickOnceVersion = Environment.GetEnvironmentVariable("ClickOnce_CurrentVersion");

        if (!string.IsNullOrEmpty(clickOnceVersion))
            lblVersion.Text = $"Version {clickOnceVersion}";
        else
        {
            var version = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
            lblVersion.Text = $"Version {version}";
        }
    }
}
