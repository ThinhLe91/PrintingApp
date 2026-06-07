using DISCPrinting.Application.Dtos.BatchDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using DISCPrinting.Infrastructure.Winform.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Printing;
using System.Text;
using System.Text.RegularExpressions;

namespace DISCPrinting.WinUI.Forms;

public partial class TestPrintUC : BaseUserControl
{
    public override string PageTitle => "TEST PRINT";
    private string TemplatePath = "";
    private Dictionary<string, string> dataDict = new Dictionary<string, string>
{
    { "DocumentNo", "HcP-001385-002" },
    { "Version", "005" },
    { "Owner", "HcP/MFE1.11 Production Engineer" },
    { "Date", DateTime.Now.ToString("dd-MM-yyyy") },
    { "BatchId", "26E22A8310" },
    { "Department", "HcP/MFE1.11" },
    { "ProcessOwner", "HcP/MFE1.12" },
    { "User", "Nguyen Van A" },
    { "ArticleNumberCoil", "0320800410" },
    { "ArticleNumberDB", "1260200832" },
    { "BatchNumberFB", "26E22A8310" },
    { "BatchNumberDB", "26E22A8311" },
    { "TrackNo", "1" },
    { "TrackNo2", "21" },
    { "CoilBatch", "535136/948" },
    { "ToolID", "T0092" },
    { "DeburringTime", "DISC   15min" },//3 dau cach - a. Huynh Phuoc Hoa
    { "Machine", "0830" },
    { "BoxNo", "1" },
    { "TrackMachineToolID", "1-0830-T0092" },
    { "ArticleNumberVersion", "1260.200.832 001" },
    { "Step", "4200" },
    { "BatchNoStep", "260313A941  4200" },
    { "BatchH", "26E22A8311" },
    { "QuantityQ", "3120" },
    { "Quantity", "23100" },
    { "PartNo", "1260.200.825" },
    { "DateBoxID", "26E22A8311/3120/" + DateTime.Now.ToString("HHmmss") },
    { "MeltBatch", "535136" },
    { "RollingBatch", "948" },
    { "RingNoCoil", "0026" },
    { "MaterialNo", "0320.800.526" }
};
    public TestPrintUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
    }

    private void LoadPaperTypeToComboBox()
    {
        cbPaperType.Items.Clear();
        foreach (var item in new string[] { "a4-portrait", "a4-landscape", "a5-portrait", "label-85x58" })
        {
            cbPaperType.Items.Add(item);
        }
    }

    private async Task LoadTemplateToComboBox()
    {
        cbPrintTemplate.Items.Clear();
        TemplatePath = await ExecuteServiceAsync<ISettingProvider, string>(_ => _.GetByKey(SettingKeys.Client.TemplatePath, ExecuteService<IClientProvider,string>(_ => _.GetMachineGuid())));
        if (string.IsNullOrEmpty(TemplatePath))
            TemplatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HTMLReports");
        if (Directory.Exists(TemplatePath))
        {
            foreach (var item in Directory.GetFiles(TemplatePath, "*.html"))
            {
                cbPrintTemplate.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
        }
    }

    private void LoadPrintersToComboBox()
    {
        cbPaperPrinter.Items.Clear();
        cbLabelPrinter.Items.Clear();
        foreach (string printer in PrinterSettings.InstalledPrinters)
        {
            cbPaperPrinter.Items.Add(printer);
            cbLabelPrinter.Items.Add(printer);
        }
        // Lấy tên máy in mặc định của hệ thống
        PrinterSettings settings = new PrinterSettings();
        string defaultPrinter = settings.PrinterName;

        int defaultIndex = cbPaperPrinter.FindStringExact(defaultPrinter);
        cbPaperPrinter.SelectedIndex = (defaultIndex != -1) ? defaultIndex : 0;
        cbLabelPrinter.SelectedIndex = (defaultIndex != -1) ? defaultIndex : 0;
    }

    private List<string> ExtractDataValues(string htmlContent)
    {
        List<string> results = new List<string>();
        string pattern = @"data-value=""([^""]*)""";

        MatchCollection matches = Regex.Matches(htmlContent, pattern, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            results.Add(match.Groups[1].Value);
        }

        return results.Distinct().Order().ToList();
    }

    private void cbPrintTemplate_SelectedIndexChanged(object sender, EventArgs e)
    {
        string filePath = Path.Combine(TemplatePath, cbPrintTemplate.SelectedItem + ".html");
        if (File.Exists(filePath))
        {
            string contentFile = File.ReadAllText(filePath);
            var keys = ExtractDataValues(contentFile);
            StringBuilder sb = new StringBuilder();
            foreach (var key in keys)
            {
                if (dataDict.TryGetValue(key, out string data))
                {
                    sb.AppendLine($"{key}: {data}");
                }
                else
                    sb.AppendLine($"{key}:");
            }
            rtbData.Text = sb.ToString();

            foreach (var item in cbPaperType.Items)
            {
                var paperType = item.ToString();
                if (!string.IsNullOrEmpty(paperType) && contentFile.Contains($"{paperType}.css"))
                {
                    cbPaperType.SelectedItem = item;
                    break;
                }
            }
        }
    }

    private async void btnPrint_Click(object sender, EventArgs e)
    {
        string filePath = Path.Combine(TemplatePath, cbPrintTemplate.SelectedItem + ".html");
        string printerName = cbPaperPrinter.SelectedItem?.ToString() ?? "";

        if (File.Exists(filePath) && !string.IsNullOrEmpty(printerName)
            && double.TryParse(txtPageWidth.Text, out double pageWidth)
            && double.TryParse(txtPageHeight.Text, out double pageHeight)
            )
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity)) quantity = 1;
            for (int i = 0; i < quantity; i++)
            {
                var res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintHtmlFile(filePath, printerName,
                    pageWidth, pageHeight, ckLandscape.Checked, GetDataDict()));
                if (!res.IsOk)
                {
                    MessageBox.Show(res.Message, "Notification");
                    break;
                }
            }
        }
        else if (string.IsNullOrEmpty(printerName))
        {
            MessageBox.Show("Please choose printer", "Notification");
        }

    }

    private Dictionary<string, string> GetDataDict()
    {
        var dictionary = new Dictionary<string, string>();

        string[] lines = rtbData.Text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var line in lines)
        {
            int colonIndex = line.IndexOf(':');

            if (colonIndex > 0)
            {
                string key = line.Substring(0, colonIndex).Trim();
                string value = line.Substring(colonIndex + 1).Trim();

                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, value);
                }
            }
        }
        return dictionary;
    }

    private void cbPaperType_SelectedIndexChanged(object sender, EventArgs e)
    {
        string paperType = cbPaperType.SelectedItem?.ToString() ?? "";
        if (!string.IsNullOrEmpty(paperType))
        {
            switch (paperType)
            {
                case "a4-portrait":
                    txtPageWidth.Text = "8.27";
                    txtPageHeight.Text = "11.69";
                    break;
                case "a4-landscape":
                    txtPageWidth.Text = "11.69";
                    txtPageHeight.Text = "8.27";
                    break;
                case "a5-portrait":
                    txtPageWidth.Text = "5.83";
                    txtPageHeight.Text = "8.27";
                    break;
                case "label-85x58":
                    txtPageWidth.Text = "3.7";
                    txtPageHeight.Text = "3";
                    break;
                default:
                    break;
            }
            ckLandscape.Checked = paperType.ToLower().Contains("landscape");
            txtPageWidth.Enabled = paperType == "label-85x58";
            txtPageHeight.Enabled = paperType == "label-85x58";
        }
    }

    private async void TestPrintUC_Load(object sender, EventArgs e)
    {
        LoadPrintersToComboBox();
        await LoadTemplateToComboBox();
        LoadPaperTypeToComboBox();
    }

    private async void btnPrintFB_Click(object sender, EventArgs e)
    {
        string docPrinterName = cbPaperPrinter.SelectedItem?.ToString() ?? "";
        string labelPrinterName = cbLabelPrinter.SelectedItem?.ToString() ?? "";
        var dataDict = GetDataDict();
        BatchInputDto batchDto = new BatchInputDto
        {
            ArticleNumberCoil = dataDict.ContainsKey("ArticleNumberCoil") ? dataDict["ArticleNumberCoil"] : "0320800410",
            ArticleNumberDB = dataDict.ContainsKey("ArticleNumberDB") ? dataDict["ArticleNumberDB"] : "0320800410",
            ArticleNumberFB = dataDict.ContainsKey("ArticleNumberFB") ? dataDict["ArticleNumberFB"] : "0320800410",
            CoilCharge = dataDict.ContainsKey("CoilCharge") ? dataDict["CoilCharge"] : "0320800410",
            Machine = dataDict.ContainsKey("Machine") ? dataDict["Machine"] : "0320800410",
            ToolId = dataDict.ContainsKey("ToolId") ? dataDict["ToolId"] : "0320800410"
        };
        var validator = new BatchInputDtoValidator();
        var checkResult = validator.Validate(batchDto);
        if (checkResult?.Errors?.Count > 0)
        {
            errorProvider1.ApplyValidationErrors(checkResult, this);
        }    
        var res = await ExecuteServiceAsync<IBatchService, string>(_ => _.CreateBatch(batchDto));
        if (!string.IsNullOrEmpty(res))
        {
            var printRes = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBFlow(docPrinterName, labelPrinterName,
                Enumerable.Range(1, 5).ToList(), res));
            if (!printRes.IsOk)
            {
                MessageBox.Show(printRes.Message);
            }
        }
    }
}
