using DISCPrinting.WinUI.Forms;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class HeaderUC : BaseUserControl
{
    public event Action LogoutChange;
    public override string PageTitle => "";
    public string homeTitle = "DISC - PRINTING APP";
    public HeaderUC(IServiceScopeFactory serviceScope) : base(serviceScope)
    {
        InitializeComponent();
        if (ExecuteService<IUserService, bool>(_ => _.IsAuthenticated))
        {
            lblDisplayUser.Text = ExecuteService<IUserService, UserInformation>(_ => _.LoginUser).DisplayName;
        }
        else
        {
            lblDisplayUser.Text = "";
        }
    }

    private void Logout()
    {
        ExecuteService<IUserService>(_ => _.Logout());
        LogoutChange?.Invoke();
    }

    private void GotoHome()
    {
        lblTitle.Text = homeTitle;
        picBack.Hide();
        picPrinter.Show();
        NavigateTo<HomeUC>();
    }

    private void ShowContextMenu()
    {
        int x = iconMoreVert.Width - contextMenuStrip.Width;
        int y = iconMoreVert.Height;
        contextMenuStrip.Show(iconMoreVert, new Point(x, y));
    }

    private void lblDisplayUser_Click(object sender, EventArgs e)
    {
        ShowContextMenu();
    }

    public void SetTitle(string title)
    {
        lblTitle.Text = title;
        if (title == homeTitle)
        {
            picPrinter.Show();
            picBack.Hide();
        }
        else
        {
            picPrinter.Hide();
            picBack.Show();
        }
    }

    private void picBack_Click(object sender, EventArgs e)
    {
        GotoHome();
    }

    private void lblTitle_Click(object sender, EventArgs e)
    {
        GotoHome();
    }

    private void settingToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void testPrintToolStripMenuItem_Click(object sender, EventArgs e)
    {
        NavigateTo<TestPrintUC>();
    }

    private void iconMoreVert_Click(object sender, EventArgs e)
    {
        ShowContextMenu();
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Logout();
    }

    private void generalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        NavigateTo<SettingUC>();
    }

    private void authorizeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        NavigateTo<AuthorizeUC>();
    }
}
