namespace DISCPrinting.WinUI.Forms.CommonUC;

public partial class PrintCommandUC : UserControl
{
    public event EventHandler? ClearClick;
    public event EventHandler? PrintClick;
    public PrintCommandUC()
    {
        InitializeComponent();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearClick?.Invoke(this, e);
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
        PrintClick?.Invoke(this, e);
    }
}
