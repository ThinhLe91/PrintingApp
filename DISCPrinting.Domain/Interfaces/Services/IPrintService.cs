using DISCPrinting.Domain.ValueObjects;

namespace DISCPrinting.Domain.Interfaces.Services;
public interface IPrintService
{
    Task<CustomResult> PrintDBBarcodeLabel(List<int> processes, string v, string docPrinterName);
    Task<CustomResult> PrintDBBookingForm(List<int> processes, string v, string docPrinterName);
    Task<CustomResult> PrintDBFlow(string docPrinterName, string labelPrinterName, List<int> processes, string batchId);
    Task<CustomResult> PrintFBBookingForm(string v, string docPrinterName);
    Task<CustomResult> PrintFBFlow(string docPrinterName, string labelPrinterName, List<int> processes, string batchId);
    Task<CustomResult> PrintFBMainGuidanceSheet(List<int> processes, string batchId, string printerName);
    Task<CustomResult> PrintFBMeasuringLabel(List<int> processes, string v, string docPrinterName);
    Task<CustomResult> PrintFBMeasuringSheet(string v, string docPrinterName);
    Task<CustomResult> PrintFBStorageLabel(List<int> processes, string v, string docPrinterName);
    Task<CustomResult> PrintFBSubGuidanceSheet(List<int> processes, string batchId, string printerName);
    Task<CustomResult> PrintHtmlFile(string htmlPath, string printerName, double pageWidth, double pageHeight, bool isLandscape = false,
        Dictionary<string, string>? dataDict = null, Dictionary<string, Dictionary<string, string>>? tableDict = null);
    Task<CustomResult> PrintPFCBarcodeLabel(List<int> processes, string v, string docPrinterName);
    Task<CustomResult> PrintPFCBarcodeSheet(List<int> processes, string v, string docPrinterName);
    Task<CustomResult> PrintPFCFlow(string docPrinterName, string labelPrinterName, List<int> processes, string batchId);
}
