using DISCPrinting.Application.Dtos.DataMasterDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.ValueObjects;
using DISCPrinting.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace DISCPrinting.WinUI.Forms;

public partial class FineBlankingUC : BaseUserControl
{
    IServiceProvider _serviceProvider;
    public override string PageTitle => "Fine Blanking && Deburring";
    public FineBlankingUC(IServiceProvider serviceProvider, IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
        LoadTab(0);
    }

    private void LoadTab(int tabIndex)
    {
        if (tabIndex == 0)
        {
            if (tbpNewBatch.Controls.Count > 0)
            {
                var oldControl = tbpNewBatch.Controls[0] as BaseUserControl;
                tbpNewBatch.Controls.Clear();
                oldControl?.Dispose();
            }
            FineBlankingNewUC newControl = _serviceProvider.GetRequiredService<FineBlankingNewUC>();
            newControl.Dock = DockStyle.Fill;
            tbpNewBatch.Controls.Add(newControl);
        }
        else if (tabIndex == 1)
        {
            if (tbpRePrint.Controls.Count > 0)
            {
                var oldControl = tbpRePrint.Controls[0] as BaseUserControl;
                tbpRePrint.Controls.Clear();
                oldControl?.Dispose();
            }
            FineBlankingRePrintUC newControl = _serviceProvider.GetRequiredService<FineBlankingRePrintUC>();
            newControl.Dock = DockStyle.Fill;
            tbpRePrint.Controls.Add(newControl);
        }
        else if (tabIndex == 2)
        {
            if (tbpCombine.Controls.Count > 0)
            {
                var oldControl = tbpCombine.Controls[0] as BaseUserControl;
                tbpCombine.Controls.Clear();
                oldControl?.Dispose();
            }
            FineBlankingCombineUC newControl = _serviceProvider.GetRequiredService<FineBlankingCombineUC>();
            newControl.Dock = DockStyle.Fill;
            tbpCombine.Controls.Add(newControl);
        }
        else if (tabIndex == 3)
        {
            if (tbpCombineHistory.Controls.Count > 0)
            {
                var oldControl = tbpCombineHistory.Controls[0] as BaseUserControl;
                tbpCombineHistory.Controls.Clear();
                oldControl?.Dispose();
            }
            FineBlankingHistoryUC newControl = _serviceProvider.GetRequiredService<FineBlankingHistoryUC>();
            newControl.Dock = DockStyle.Fill;
            tbpCombineHistory.Controls.Add(newControl);
        }
        NormalTheme.Apply(Controls);
    }

    private void tbcFB_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadTab(tbcFB.SelectedIndex);
    }
}