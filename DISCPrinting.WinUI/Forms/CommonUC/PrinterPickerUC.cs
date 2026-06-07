using System.Drawing.Printing;

namespace DISCPrinting.WinUI.Forms;

public partial class PrinterPickerUC : UserControl
{
    public event Action<string>? PaperPrinterSelectionChanged;
    public event Action<string>? LabelPrinterSelectionChanged;
    public PrinterPickerUC()
    {
        InitializeComponent();
        LoadPrinter();
    }

    private void LoadPrinter()
    {
        cboLabelPrinter.Items.Clear();
        cboPaperPrinter.Items.Clear();
        foreach (var printerName in PrinterSettings.InstalledPrinters)
        {
            cboPaperPrinter.Items.Add(printerName);
            cboLabelPrinter.Items.Add(printerName);
        }
        PrinterSettings settings = new PrinterSettings();
        string defaultPrinter = settings.PrinterName;

        int defaultIndex = cboLabelPrinter.FindStringExact(defaultPrinter);
        cboPaperPrinter.SelectedIndex = (defaultIndex != -1) ? defaultIndex : 0;
        cboLabelPrinter.SelectedIndex = (defaultIndex != -1) ? defaultIndex : 0;
    }

    private void cboPaperPrinter_SelectedIndexChanged(object sender, EventArgs e)
    {
        PaperPrinterSelectionChanged?.Invoke(cboPaperPrinter.SelectedItem?.ToString() ?? "");
    }

    private void cboLabelPrinter_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelPrinterSelectionChanged?.Invoke(cboLabelPrinter.SelectedItem?.ToString() ?? "");
    }

    public void SetPaperPrinterVisibility(bool visible)
    {
        var rowStyle = tlpLayout.RowStyles[1];
        if (visible)
        {
            rowStyle.SizeType = SizeType.Percent;
            rowStyle.Height = 30;
        }
        else
        {
            rowStyle.SizeType = SizeType.Percent;
            rowStyle.Height = 0;
        }
    }

    public void SetLabelPrinterVisibility(bool visible)
    {
        var rowStyle = tlpLayout.RowStyles[2];
        if (visible)
        {
            rowStyle.SizeType = SizeType.Percent;
            rowStyle.Height = 30;
        }
        else
        {
            rowStyle.SizeType = SizeType.Percent;
            rowStyle.Height = 0;
        }
    }

    public void SetPaperPrinter(string printerName)
    {
        int index = cboPaperPrinter.FindStringExact(printerName);
        if (index != -1) cboPaperPrinter.SelectedIndex = index;
    }

    public void SetLabelPrinter(string printerName)
    {
        int index = cboLabelPrinter.FindStringExact(printerName);
        if (index != -1) cboLabelPrinter.SelectedIndex = index;
    }
}
