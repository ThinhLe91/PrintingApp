using DISCPrinting.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class LoginUC : BaseUserControl
{
    public event Action LoginSuccessChange;
    public override string PageTitle => "LOGIN";
    public LoginUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
        ResetForm();
        NormalTheme.Apply(Controls);
    }

    private void ResetForm()
    {
        lnkUsername.Text = "APAC/" + ExecuteService<IUserService, string>(_ => _.WindowUser);
        txtUsername.Text = "";
        txtPassword.Text = "";
    }

    private async void DoLogin()
    {
        errorProvider.Clear();
        var username = txtUsername.Text.Trim();
        var password = txtPassword.Text.Trim();
        if (!string.IsNullOrEmpty(username))
        {
            var loginRes = await ExecuteServiceAsync<IUserService, bool>(_ => _.Login(username, password));
            if (loginRes)
            {
                ResetForm();
                LoginSuccessChange?.Invoke();
            }
            else
            {
                MessageBox.Show("Login failed", "Notification");
            }
        }
        else
        {
            errorProvider.SetError(txtUsername, "Please input username");
        }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        DoLogin();
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            DoLogin();
    }

    private async void lnkUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        SetBusyState(true);
        var loginRes = await ExecuteServiceAsync<IUserService, bool>(_ => _.Login(ExecuteService<IUserService, string>(_ => _.WindowUser), ""));
        if (loginRes)
        {
            ResetForm();
            LoginSuccessChange?.Invoke();
        }
        else
        {
            MessageBox.Show("Login failed", "Notification");
        }
        SetBusyState(false);
    }
}
