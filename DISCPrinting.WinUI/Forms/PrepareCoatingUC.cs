using DISCPrinting.Application.Dtos.DataMasterDtos;
using DISCPrinting.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class PrepareCoatingUC : BaseUserControl
{
    public override string PageTitle => "Preparation For Coating";
    private string _paperPrinterName = "";
    private string _labelPrinterName = "";
    private string _currentBatchId = "";

    private Dictionary<string, string> _settings = new Dictionary<string, string>();
    List <MachineOutputDto> _coatingMachine = new List<MachineOutputDto>();



    public PrepareCoatingUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
    }

    private void tlpCoatingBatchInfo_Paint(object sender, PaintEventArgs e)
    {

    }
}
