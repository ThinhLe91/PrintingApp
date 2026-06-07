using DISCPrinting.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class HomeUC : BaseUserControl
{
    public override string PageTitle => "DISC - PRINTING APP";
    public HomeUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
    }

    private void btnFineBlanking_Click(object sender, EventArgs e)
    {
        NavigateTo<FineBlankingUC>();
    }

    private void btnPrepareCoating_Click(object sender, EventArgs e)
    {
        NavigateTo<PrepareCoatingUC>();
    }

    private void btnAOI_Click(object sender, EventArgs e)
    {
        NavigateTo<AOIUC>();
    }

    private void btnSystemSetting_Click(object sender, EventArgs e)
    {

    }
}
