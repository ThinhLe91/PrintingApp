using DISCPrinting.Application.Dtos.BatchDtos;
using DISCPrinting.Application.Dtos.DataMasterDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace DISCPrinting.WinUI.Forms;

public partial class FineBlankingNewUC : BaseUserControl
{
    public override string PageTitle => "Fine Blanking && Deburring";
    private List<int> _batchSelectionList = new List<int>();
    private string _paperPrinterName = "";
    private string _labelPrinterName = "";
    private string _currentBatchId = "";
    private Dictionary<string, string> _settings = new Dictionary<string, string>();
    List<MachineOutputDto> machines = new List<MachineOutputDto>();
    public FineBlankingNewUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
        batchPickeruc1.BatchSelectionChanged += BatchPickeruc1_BatchSelectionChanged;
        printerPickeruc1.PaperPrinterSelectionChanged += PrinterPickeruc1_PaperPrinterSelectionChanged;
        printerPickeruc1.LabelPrinterSelectionChanged += PrinterPickeruc1_LabelPrinterSelectionChanged;
        printCommand.PrintClick += PrintCommand_PrintClick;
        printCommand.ClearClick += PrintCommand_ClearClick;
        cboNewMachine.DisplayMember = nameof(MachineOutputDto.MachineName);
        cboNewMachine.ValueMember = nameof(MachineOutputDto.MachineNumber);
        lblPrintingBatchID.Text = "";
        LoadData();
    }
    private void ClearForm()
    {
        txbNewToolID.Text = "";
        txbNewCoilCharge.Text = "";
        txbNewArticalNoCoil.Text = "";
        txbNewArticalNoFB.Text = _settings[SettingKeys.Global.ArticleNumberFB];
        txbNewArticalNoDeburr.Text = _settings[SettingKeys.Global.ArticleNumberDB];
        lblPrintingBatchID.Text = "";
        DisableForm(true);
    }
    private void DisableForm(bool isEnable)
    {
        txbNewToolID.Enabled = isEnable;
        txbNewCoilCharge.Enabled = isEnable;
        txbNewArticalNoCoil.Enabled = isEnable;
        txbNewArticalNoFB.Enabled = isEnable;
        txbNewArticalNoDeburr.Enabled = isEnable;
        lblPrintingBatchID.Enabled = isEnable;
        cboNewMachine.Enabled = isEnable;
    }
    private void PrintCommand_ClearClick(object? sender, EventArgs e)
    {
        ClearForm();
    }

    private async void PrintCommand_PrintClick(object? sender, EventArgs e)
    {
        SetBusyState(true);
        if (!string.IsNullOrEmpty(_currentBatchId))
        {
            var res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBFlow(_paperPrinterName, _labelPrinterName, _batchSelectionList, _currentBatchId));
            if (res?.IsOk == true)
            {
                if (_batchSelectionList.Count == 5)
                {
                    ClearForm();
                }
                else
                {
                    lblPrintingBatchID.Text = "Printing: " + _currentBatchId;
                    DisableForm(false);
                }
            }
        }
        else
        {
            var newBatchInput = new BatchInputDto
            {
                ArticleNumberCoil = txbNewArticalNoCoil.Text,
                ArticleNumberDB = txbNewArticalNoDeburr.Text,
                ArticleNumberFB = txbNewArticalNoFB.Text,
                CoilCharge = txbNewCoilCharge.Text,
                Machine = cboNewMachine.SelectedValue.ToString() ?? "",
                ToolId = txbNewToolID.Text,
            };
            var check = new BatchInputDtoValidator().Validate(newBatchInput);
            StringBuilder sb = new StringBuilder();

            if (!check.IsValid)
                foreach (var item in check.Errors)
                {
                    sb.AppendLine(item.ErrorMessage);
                }
            if (_batchSelectionList.Count == 0)
                sb.AppendLine("Please choose Batch to print");
            if (string.IsNullOrEmpty(_paperPrinterName))
                sb.AppendLine("Please choose printer to print paper");
            if (string.IsNullOrEmpty(_labelPrinterName))
                sb.AppendLine("Please choose printer to print label");

            if (sb.Length > 0)
                MessageBox.Show(sb.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var batchId = await ExecuteServiceAsync<IBatchService, string>(_ => _.CreateBatch(newBatchInput));
                if (!string.IsNullOrEmpty(batchId))
                {
                    lblPrintingBatchID.Text = "Printing: " + batchId;
                    var res = await ExecuteServiceAsync<IPrintService, CustomResult>(_ => _.PrintFBFlow(_paperPrinterName, _labelPrinterName, _batchSelectionList, batchId));
                    if (res?.IsOk == true)
                    {
                        if (_batchSelectionList.Count == 5)
                        {
                            ClearForm();
                        }
                        else
                        {
                            DisableForm(false);
                        }
                    }
                }

            }
        }
        SetBusyState(false);
    }

    private async void LoadData()
    {
        var clientId = ExecuteService<IClientProvider, string>(_ => _.GetMachineGuid());
        var loginUser = ExecuteService<IUserService, UserInformation>(_ => _.LoginUser);
        _settings = await ExecuteServiceAsync<ISettingProvider, Dictionary<string, string>>(_ => _.GetByKeys([
            SettingKeys.Global.ArticleNumberFB,
            SettingKeys.Global.ArticleNumberDB,
            SettingKeys.Client.DefaultPaperPrinter,
            SettingKeys.Client.DefaultLabelPrinter
            ], clientId, loginUser.Username));
        txbNewArticalNoFB.Text = _settings[SettingKeys.Global.ArticleNumberFB];
        txbNewArticalNoDeburr.Text = _settings[SettingKeys.Global.ArticleNumberDB];
        _paperPrinterName = _settings[SettingKeys.Client.DefaultPaperPrinter];
        _labelPrinterName = _settings[SettingKeys.Client.DefaultLabelPrinter];
        printerPickeruc1.SetPaperPrinter(_paperPrinterName);
        printerPickeruc1.SetLabelPrinter(_labelPrinterName);
        LoadMachines();
    }

    private void PrinterPickeruc1_LabelPrinterSelectionChanged(string obj)
    {
        _labelPrinterName = obj;
    }

    private void PrinterPickeruc1_PaperPrinterSelectionChanged(string obj)
    {
        _paperPrinterName = obj;
    }

    private void BatchPickeruc1_BatchSelectionChanged(List<int> obj)
    {
        _batchSelectionList = obj;
    }

    private async void LoadMachines()
    {
        machines = await ExecuteServiceAsync<IMachineQueryService, List<MachineOutputDto>>(_ => _.GetMachines());
        cboNewMachine.DataSource = machines;
    }
}
