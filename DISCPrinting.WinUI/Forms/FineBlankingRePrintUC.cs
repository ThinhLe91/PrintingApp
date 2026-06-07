using DISCPrinting.Application.Dtos.BatchDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DISCPrinting.WinUI.Forms;

public partial class FineBlankingRePrintUC : BaseUserControl
{
    public override string PageTitle => "Fine Blanking && Deburring";
    BatchOutputDto? _currentBatch = null;
    private List<int> _batchSelectionList = new List<int>();
    private List<int> _trackSelectionList = new List<int>();
    private string _paperPrinterName = "";
    private string _labelPrinterName = "";
    private Dictionary<string, string> _settings = new Dictionary<string, string>();
    private Dictionary<string, bool> paperTypes = new Dictionary<string, bool>
    {
        { "FB-MainGuidanceSheet", false},
        { "FB-SubGuidanceSheet", false},
        { "FB-BookingForm", false},
        { "FB-MeasuringSheet", false},
        { "FB-MeasuringLabel", false},
        { "FB-StorageLabel", false},
        { "DB-BookingForm", false},
        { "DB-SampleLabel", false}
    };
    public FineBlankingRePrintUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
        batchPicker.BatchSelectionChanged += BatchPicker_BatchSelectionChanged;
        printerPicker.LabelPrinterSelectionChanged += PrinterPicker_LabelPrinterSelectionChanged;
        printerPicker.PaperPrinterSelectionChanged += PrinterPicker_PaperPrinterSelectionChanged;
        printCommand.ClearClick += PrintCommand_ClearClick;
        printCommand.PrintClick += PrintCommand_PrintClick;
        trackPicker.TrackSelectionChanged += TrackPicker_TrackSelectionChanged;
        LoadData();
    }

    private void TrackPicker_TrackSelectionChanged(List<int> obj)
    {
        _trackSelectionList = obj;
    }

    private void ClearForm()
    {
        _currentBatch = null;
        txbArticalNumberCoil.Clear();
        txbCoilCharge.Clear();
        txbMachine.Clear();
        txbToolID.Clear();
        txtBatchId.Clear();
    }

    private async void PrintCommand_PrintClick(object? sender, EventArgs e)
    {
        List<string> paperTypes = multiSelectComboBox1.GetSelectedItems().OfType<string>().ToList();
        StringBuilder sb = new StringBuilder();
        if (_currentBatch == null)
            sb.AppendLine("Please choose Batch number to reprint");
        if (paperTypes.Count == 0)
            sb.AppendLine("Please choose paper type to reprint");
        if (_trackSelectionList.Count == 0)
            sb.AppendLine("Please choose track to reprint");
        if (_batchSelectionList.Count == 0)
            sb.AppendLine("Please choose batch to reprint");
        if (string.IsNullOrEmpty(_paperPrinterName))
            sb.AppendLine("Please choose paper printer to reprint");
        if (string.IsNullOrEmpty(_labelPrinterName))
            sb.AppendLine("Please choose label printer to reprint");
        if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            SetBusyState(true);
            CustomResult? res = null;
            if (paperTypes.Contains($"{Processes.DISC_FB}.{PaperType.MainGuidanceSheet}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBMainGuidanceSheet(_batchSelectionList, 
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
            if (paperTypes.Contains($"{Processes.DISC_FB}.{PaperType.SubGuidanceSheet}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBSubGuidanceSheet(_batchSelectionList,
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
            if (paperTypes.Contains($"{Processes.DISC_FB}.{PaperType.BookingForm}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBBookingForm(
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
            if (paperTypes.Contains($"{Processes.DISC_FB}.{PaperType.MeasuringSheet}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBMeasuringSheet(
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
            if (paperTypes.Contains($"{Processes.DISC_FB}.{PaperType.MeasuringLabel}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBMeasuringLabel(_batchSelectionList,
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
            if (paperTypes.Contains($"{Processes.DISC_FB}.{PaperType.StorageLabel}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBStorageLabel(_batchSelectionList,
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
            if (paperTypes.Contains($"{Processes.DISC_DB}.{PaperType.BookingForm}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintDBBookingForm(_batchSelectionList,
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
            if (paperTypes.Contains($"{Processes.DISC_DB}.{PaperType.BarcodeLabel}"))
            {
                foreach (var track in _trackSelectionList)
                {
                    res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintDBBarcodeLabel(_batchSelectionList,
                        $"{_currentBatch.BatchId}{track}0", _paperPrinterName));
                    if (!res.IsOk) goto Print_End;
                }
            }
        Print_End:
            if (res != null && !res.IsOk)
                MessageBox.Show(res.Message, "Notification");
            SetBusyState(false);
        }
    }

    private void PrintCommand_ClearClick(object? sender, EventArgs e)
    {
        ClearForm();
    }

    private void PrinterPicker_PaperPrinterSelectionChanged(string obj)
    {
        _paperPrinterName = obj;
    }

    private void PrinterPicker_LabelPrinterSelectionChanged(string obj)
    {
        _labelPrinterName = obj;
    }

    private void BatchPicker_BatchSelectionChanged(List<int> obj)
    {
        _batchSelectionList = obj;
    }

    private async void LoadData()
    {
        var printTemplates = await ExecuteServiceAsync<IPrintTemplateProvider, List<string>>(_ => _.GetPaperTypeByProcess([
            Processes.DISC_FB, Processes.DISC_DB
            ]));
        paperTypes = printTemplates.ToDictionary(_ => _, _ => false);
        multiSelectComboBox1.SetDataSource(paperTypes);
        var clientId = ExecuteService<IClientProvider, string>(_ => _.GetMachineGuid());
        var loginUser = ExecuteService<IUserService, UserInformation>(_ => _.LoginUser);
        _settings = await ExecuteServiceAsync<ISettingProvider, Dictionary<string, string>>(_ => _.GetByKeys([
            SettingKeys.Client.DefaultPaperPrinter,
            SettingKeys.Client.DefaultLabelPrinter
            ], clientId, loginUser.Username));
        _paperPrinterName = _settings[SettingKeys.Client.DefaultPaperPrinter];
        _labelPrinterName = _settings[SettingKeys.Client.DefaultLabelPrinter];
        printerPicker.SetPaperPrinter(_paperPrinterName);
        printerPicker.SetLabelPrinter(_labelPrinterName);
    }

    private async void txtBatchId_KeyUp(object sender, KeyEventArgs e)
    {
        if (txtBatchId.Text.Length == 10)
        {
            _currentBatch = await ExecuteServiceAsync<IBatchService, BatchOutputDto>(_ => _.GetBatchInfo(txtBatchId.Text));
            if (_currentBatch != null)
            {
                txbMachine.Text = _currentBatch.Machine;
                txbArticalNumberCoil.Text = _currentBatch.ArticleNumberCoil;
                txbCoilCharge.Text = _currentBatch.CoilCharge;
                txbToolID.Text = _currentBatch.ToolId;
                var _currentCheck = 0;
                int.TryParse(txtBatchId.Text[8].ToString(), out _currentCheck);
                trackPicker.SetChecked(true, _currentCheck == 0 ? Enumerable.Range(1, 4).ToList() : [_currentCheck]);
            }
        }
    }
}
