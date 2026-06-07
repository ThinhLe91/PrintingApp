using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Text.Json;

namespace DISCPrinting.Infrastructure.Winform.Services;

public class PrintService(ISettingProvider _settingProvider, IPrintTemplateProvider _printTemplateProvider, IBatchProvider _batchProvider,
    IDocumentProvider _documentProvider, IUserService _userService, IClientProvider _clientProvider) : IPrintService
{

    public async Task<CustomResult> PrintHtmlFile(string htmlPath, string printerName, double pageWidth, double pageHeight,
        bool isLandscape = false, Dictionary<string, string>? dataDict = null, Dictionary<string, Dictionary<string, string>>? tableDict = null)
    {
        try
        {
            var webView = new WebView2();
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate(htmlPath);
            bool isLoaded = false;
            webView.NavigationCompleted += (s, e) => { isLoaded = true; };
            while (!isLoaded) await Task.Delay(100);
            if (dataDict != null)
            {
                string jsonString = JsonSerializer.Serialize(dataDict);
                await webView.ExecuteScriptAsync($"updatePrintData(JSON.parse('{jsonString}'))");
            }
            if (tableDict != null)
            {
                foreach (var table in tableDict)
                {
                    string jsonString = JsonSerializer.Serialize(table.Value);
                    await webView.ExecuteScriptAsync($"generateDynamicTable(JSON.parse('{jsonString}'), {table.Key})");
                }
            }
            var printSettings = webView.CoreWebView2.Environment.CreatePrintSettings();
            printSettings.MediaSize = CoreWebView2PrintMediaSize.Custom;
            //printSettings.MarginTop = 0.1;
            //printSettings.MarginBottom = 0.1;
            //printSettings.MarginLeft = 0.11;
            //printSettings.MarginRight = 0.5;
            printSettings.Orientation = isLandscape ? CoreWebView2PrintOrientation.Landscape : CoreWebView2PrintOrientation.Portrait;
            printSettings.PageWidth = pageWidth;
            printSettings.PageHeight = pageHeight;
            printSettings.PrinterName = printerName;

            CoreWebView2PrintStatus status = await webView.CoreWebView2.PrintAsync(printSettings);
            string result = status switch
            {
                CoreWebView2PrintStatus.Succeeded => "",
                CoreWebView2PrintStatus.PrinterUnavailable => "Printer Unavailable",
                CoreWebView2PrintStatus.OtherError => "Other error",
                _ => "Unknown error"
            };
            webView.Dispose();
            return result == "" ? new CustomResult() : new CustomResult(result);
        }
        catch (Exception ex)
        {
            return new CustomResult(ex.Message);
        }
    }

    public async Task<CustomResult> PrintPFCFlow(string docPrinterName, string labelPrinterName, List<int> processes, string batchId)
    {
        for (int track = 1; track <= 4; track++)
        {
            var res = await PrintPFCBarcodeSheet(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;
            res = await PrintPFCBarcodeLabel(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;
        }
        return new CustomResult();
    }

    public async Task<CustomResult> PrintPFCBarcodeLabel(List<int> processes, string v, string docPrinterName)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomResult> PrintPFCBarcodeSheet(List<int> processes, string v, string docPrinterName)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomResult> PrintDBFlow(string docPrinterName, string labelPrinterName, List<int> processes, string batchId)
    {
        for (int track = 1; track <= 4; track++)
        {
            var res = await PrintDBBookingForm(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;
            res = await PrintDBBarcodeLabel(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;
        }
        return new CustomResult();
    }

    public async Task<CustomResult> PrintDBBarcodeLabel(List<int> processes, string v, string docPrinterName)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomResult> PrintDBBookingForm(List<int> processes, string v, string docPrinterName)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomResult> PrintFBFlow(string docPrinterName, string labelPrinterName, List<int> processes, string batchId)
    {
        for (int track = 1; track <= 4; track++)
        {
            var res = await PrintFBMainGuidanceSheet(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;

            res = await PrintFBSubGuidanceSheet(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;

            res = await PrintFBBookingForm($"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;

            res = await PrintFBMeasuringSheet($"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;

            res = await PrintFBMeasuringLabel(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;

            res = await PrintFBStorageLabel(processes, $"{batchId}{track}0", docPrinterName);
            if (!res.IsOk) return res;
        }

        return new CustomResult();
    }

    public async Task<CustomResult> PrintFBStorageLabel(List<int> processes, string v, string docPrinterName)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomResult> PrintFBMeasuringLabel(List<int> processes, string v, string docPrinterName)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomResult> PrintFBMeasuringSheet(string batchId, string printerName)
    {
        var printTemplateDir = await _settingProvider.GetByKey(SettingKeys.Client.TemplatePath,
            _clientProvider.GetMachineGuid(), _userService.LoginUser.Username);
        if (string.IsNullOrEmpty(printTemplateDir)) printTemplateDir = AppDomain.CurrentDomain.BaseDirectory;

        PrintTemplateEntity printTemplate = await _printTemplateProvider.GetPrintTemplateInformation(Processes.DISC_FB, PaperType.MeasuringSheet);
        int currentTrack = 0;
        if (batchId.Length == 10)
        {
            int.TryParse(batchId[8].ToString(), out currentTrack);
        }
        var batch = await _batchProvider.GetBatchInformation(batchId.Substring(0, 8));
        var document = await _documentProvider.GetDocumentByVersion(batch.DocumentVersion);

        Dictionary<string, string> dataDict = new Dictionary<string, string>();
        dataDict.Add(nameof(document.No), document.No);
        dataDict.Add(nameof(document.Owner), document.Owner);
        dataDict.Add(nameof(document.Version), document.Version);
        dataDict.Add(nameof(document.RevisionDate), document.RevisionDate);
        dataDict.Add(nameof(document.ManagedBy), document.ManagedBy);
        dataDict.Add(nameof(document.Reference), document.Reference);
        dataDict.Add(nameof(document.VersionNotice), document.VersionNotice);

        dataDict.Add("BatchNumberFB", batchId);
        dataDict.Add(nameof(batch.ArticleNumberCoil), batch.ArticleNumberCoil);
        dataDict.Add(nameof(batch.Machine), batch.Machine);
        dataDict.Add(nameof(batch.ProductionVersion), batch.ProductionVersion);
        dataDict.Add("ArticleNumberVersion", $"{batch.ArticleNumberFB} {batch.ProductionVersion}");

        string htmlPath = Path.Combine(printTemplateDir, printTemplate.FileName);
        if (!File.Exists(htmlPath)) return new CustomResult($"File {printTemplate.FileName} is not exist");

        for (int i = 0; i < printTemplate.NumberOfPrint; i += 2)
        {
            dataDict.Add("BookingNo1", (i + 1).ToString());
            dataDict.Add("BookingNo2", (i + 2).ToString());
            var res = await PrintHtmlFile(htmlPath, printerName, printTemplate.Width, printTemplate.Height, printTemplate.IsLandscape, dataDict);
            if (!res.IsOk)
                return res;
        }

        return new CustomResult();
    }

    public async Task<CustomResult> PrintFBBookingForm(string batchId, string printerName)
    {
        var printTemplateDir = await _settingProvider.GetByKey(SettingKeys.Client.TemplatePath,
            _clientProvider.GetMachineGuid(), _userService.LoginUser.Username);
        if (string.IsNullOrEmpty(printTemplateDir)) printTemplateDir = AppDomain.CurrentDomain.BaseDirectory;

        PrintTemplateEntity printTemplate = await _printTemplateProvider.GetPrintTemplateInformation(Processes.DISC_FB, PaperType.BookingForm);
        int currentTrack = 0;
        if (batchId.Length == 10)
        {
            int.TryParse(batchId[8].ToString(), out currentTrack);
        }
        var batch = await _batchProvider.GetBatchInformation(batchId.Substring(0, 8));
        var document = await _documentProvider.GetDocumentByVersion(batch.DocumentVersion);

        Dictionary<string, string> dataDict = new Dictionary<string, string>();
        dataDict.Add(nameof(document.No), document.No);
        dataDict.Add(nameof(document.Owner), document.Owner);
        dataDict.Add(nameof(document.Version), document.Version);
        dataDict.Add(nameof(document.RevisionDate), document.RevisionDate);
        dataDict.Add(nameof(document.ManagedBy), document.ManagedBy);
        dataDict.Add(nameof(document.Reference), document.Reference);
        dataDict.Add(nameof(document.VersionNotice), document.VersionNotice);

        dataDict.Add(nameof(batch.ArticleNumberFB), batch.ArticleNumberFB);
        dataDict.Add(nameof(batch.ArticleNumberCoil), batch.ArticleNumberCoil);
        dataDict.Add(nameof(batch.Machine), batch.Machine);
        dataDict.Add(nameof(batch.ProductionVersion), batch.ProductionVersion);

        string htmlPath = Path.Combine(printTemplateDir, printTemplate.FileName);
        if (!File.Exists(htmlPath)) return new CustomResult($"File {printTemplate.FileName} is not exist");

        for (int i = 0; i < printTemplate.NumberOfPrint; i += 2)
        {
            dataDict["BookingNo1"] = (i + 1).ToString();
            dataDict["BookingNo2"] = (i + 2).ToString();
            var res = await PrintHtmlFile(htmlPath, printerName, printTemplate.Width, printTemplate.Height, printTemplate.IsLandscape, dataDict);
            if (!res.IsOk)
                return res;
        }

        return new CustomResult();
    }

    public async Task<CustomResult> PrintFBMainGuidanceSheet(List<int> processes, string batchId, string printerName)
    {
        var printTemplateDir = await _settingProvider.GetByKey(SettingKeys.Client.TemplatePath,
            _clientProvider.GetMachineGuid(), _userService.LoginUser.Username);
        if (string.IsNullOrEmpty(printTemplateDir)) printTemplateDir = AppDomain.CurrentDomain.BaseDirectory;

        PrintTemplateEntity printTemplate = await _printTemplateProvider.GetPrintTemplateInformation(Processes.DISC_FB, PaperType.MainGuidanceSheet);
        int currentTrack = 0;
        if (batchId.Length == 10)
        {
            int.TryParse(batchId[8].ToString(), out currentTrack);
        }
        var batch = await _batchProvider.GetBatchInformation(batchId.Substring(0, 8));
        var document = await _documentProvider.GetDocumentByVersion(batch.DocumentVersion);

        #region Create Print Dictionary
        Dictionary<string, string> dataDict = new Dictionary<string, string>();
        dataDict.Add(nameof(document.No), document.No);
        dataDict.Add(nameof(document.Owner), document.Owner);
        dataDict.Add(nameof(document.Version), document.Version);
        dataDict.Add(nameof(document.RevisionDate), document.RevisionDate);
        dataDict.Add(nameof(document.ManagedBy), document.ManagedBy);
        dataDict.Add(nameof(document.Reference), document.Reference);
        dataDict.Add(nameof(document.VersionNotice), document.VersionNotice);

        dataDict.Add(nameof(batch.ArticleNumberFB), batch.ArticleNumberFB);
        dataDict.Add(nameof(batch.ArticleNumberCoil), batch.ArticleNumberCoil);
        dataDict.Add(nameof(batch.ArticleNumberDB), batch.ArticleNumberDB);
        dataDict.Add("BatchCreatedDate", batch.CreatedUtcDate.ToLocalTime().ToString("dd-MM-yyyy"));
        dataDict.Add("BatchNumberFB", batchId);
        dataDict.Add("BatchNumberDB", "");
        dataDict.Add("CoilBatch", batch.CoilCharge.Substring(0, batch.CoilCharge.LastIndexOf('/')));
        dataDict.Add("DeburringTime", await _settingProvider.GetByKey(SettingKeys.Global.DeburringTime));
        dataDict.Add(nameof(batch.Machine), batch.Machine);
        dataDict.Add("MeltBatch", batch.CoilCharge.Split('/')[0]);
        dataDict.Add(nameof(batch.ProductionVersion), batch.ProductionVersion);
        dataDict.Add("RingNoCoil", batch.CoilCharge.Split('/')[2]);
        dataDict.Add("RollingBatch", batch.CoilCharge.Split('/')[1]);
        dataDict.Add(nameof(batch.ToolId), batch.ToolId);
        dataDict.Add("TrackNo", currentTrack.ToString());
        #endregion

        string htmlPath = Path.Combine(printTemplateDir, printTemplate.FileName);
        if (!File.Exists(htmlPath)) return new CustomResult($"File {printTemplate.FileName} is not exist");

        foreach (var process in processes)
        {
            dataDict["BatchNumberDB"] = $"{batch.BatchId}{currentTrack}{process}";
            var res = await PrintHtmlFile(htmlPath, printerName, printTemplate.Width, printTemplate.Height, printTemplate.IsLandscape, dataDict);
            if (!res.IsOk)
                return res;
        }

        return new CustomResult();
    }

    public async Task<CustomResult> PrintFBSubGuidanceSheet(List<int> processes, string batchId, string printerName)
    {
        var printTemplateDir = await _settingProvider.GetByKey(SettingKeys.Client.TemplatePath,
            _clientProvider.GetMachineGuid(), _userService.LoginUser.Username);
        if (string.IsNullOrEmpty(printTemplateDir)) printTemplateDir = AppDomain.CurrentDomain.BaseDirectory;
        int currentTrack = 0;
        if (batchId.Length == 10)
        {
            int.TryParse(batchId[8].ToString(), out currentTrack);
        }
        var batch = await _batchProvider.GetBatchInformation(batchId.Substring(0, 8));
        var document = await _documentProvider.GetDocumentByVersion(batch.DocumentVersion);

        #region SubGuidanceSheet
        var printTemplate = await _printTemplateProvider.GetPrintTemplateInformation(Processes.DISC_FB, PaperType.SubGuidanceSheet);
        var htmlPath = Path.Combine(printTemplateDir, printTemplate.FileName);

        Dictionary<string, string> dataDict = new Dictionary<string, string>();
        dataDict.Add(nameof(document.No), document.No);
        dataDict.Add(nameof(document.Owner), document.Owner);
        dataDict.Add(nameof(document.Version), document.Version);
        dataDict.Add(nameof(document.RevisionDate), document.RevisionDate);
        dataDict.Add(nameof(document.ManagedBy), document.ManagedBy);
        dataDict.Add(nameof(document.Reference), document.Reference);
        dataDict.Add(nameof(document.VersionNotice), document.VersionNotice);
        dataDict.Add("BatchNumberFB", batchId);

        List<int> pages = new List<int>();
        foreach (var process in processes)
        {
            switch (process)
            {
                case 1:
                    pages.AddRange(Enumerable.Range(1, 8));
                    break;
                case 2:
                    pages.AddRange(Enumerable.Range(8, 16));
                    break;
                case 3:
                    pages.AddRange(Enumerable.Range(17, 24));
                    break;
                case 4:
                    pages.AddRange(Enumerable.Range(25, 32));
                    break;
                case 5:
                    pages.AddRange(Enumerable.Range(33, 40));
                    break;
                default:
                    break;
            }
        }
        int limit = pages.Count / 2;
        for (int i = 0; i < limit; i++)
        {
            dataDict["BoxNo1"] = pages[i].ToString();
            dataDict["BoxNo2"] = pages[limit + i].ToString();
            var res = await PrintHtmlFile(htmlPath, printerName, printTemplate.Width, printTemplate.Height, printTemplate.IsLandscape, dataDict);
            if (!res.IsOk)
                return res;
        }
        #endregion
        return new CustomResult();
    }
}

