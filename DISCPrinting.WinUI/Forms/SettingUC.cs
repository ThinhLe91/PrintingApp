using DISCPrinting.Application.Dtos.SettingDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms;

public partial class SettingUC : BaseUserControl
{
    private List<SettingOutputDto> _appSettings;
    private BindingSource _bindingSource = new BindingSource();
    public override string PageTitle => "SETTING";
    public SettingUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
        SetupGridView();
    }

    private void SetupGridView()
    {
        dgvSetting.Columns.Clear();

        dgvSetting.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(SettingOutputDto.SettingKey),
            HeaderText = "Key",
            Width = 150,
            ReadOnly = true
        });

        dgvSetting.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(SettingOutputDto.SettingValue),
            HeaderText = "Value",
            ReadOnly = false,

        });

        dgvSetting.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(SettingOutputDto.SettingDescription),
            HeaderText = "Description",
            ReadOnly = true,
        });

        dgvSetting.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(SettingOutputDto.ClientId),
            HeaderText = "Client",
            ReadOnly = true,
        });

        dgvSetting.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(SettingOutputDto.User),
            HeaderText = "User",
            ReadOnly = true,
        });
        dgvSetting.DataSource = _bindingSource;
        dgvSetting.AutoGenerateColumns = false;
        dgvSetting.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        dgvSetting.AllowUserToAddRows = false;
        dgvSetting.CellValueChanged += DgvSetting_CellValueChanged;
    }

    private async void DgvSetting_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            var editItem = _appSettings[e.RowIndex] as SettingOutputDto;
            if (editItem != null)
            {
                if ((editItem.Scope == nameof(SettingKeys.Client) && !string.IsNullOrEmpty(editItem.ClientId))
                    || (editItem.Scope == nameof(SettingKeys.User) && !string.IsNullOrEmpty(editItem.User))
                    )
                {
                    await ExecuteServiceAsync<ISettingService, bool>(_ => _.Update(editItem.Id, editItem.SettingValue));
                }
                else
                    await ExecuteServiceAsync<ISettingService, bool>(_ => _.Upsert(editItem.Scope, editItem.SettingKey, editItem.SettingValue));
            }
        }
        await LoadSetting();
    }

    private async Task LoadSetting()
    {
        _appSettings = await ExecuteServiceAsync<ISettingService, List<SettingOutputDto>>(_ => _.GetSettings());
        _bindingSource.DataSource = _appSettings;
    }

    private async void SettingUC_Load(object sender, EventArgs e)
    {
        await LoadSetting();
    }
}
