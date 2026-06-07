using DISCPrinting.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class AOIUC : BaseUserControl
{
    public override string PageTitle => "AOI";
    public AOIUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
        printerPicker.SetPaperPrinterVisibility(false);
    }
}
