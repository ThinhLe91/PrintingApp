using System.Data;

namespace DISCPrinting.WinUI.Forms.CommonUC;

public partial class MultiSelectComboBox : UserControl
{
    private ToolStripDropDown _dropdown;
    private CheckedListBox _clb;
    private List<string> _checkedItems = new List<string>();
    private Dictionary<string, bool> _dataSource = new Dictionary<string, bool>();
    private bool _isUpdating = false;
    private record ItemOption(string Key, bool? IsChecked);
    public MultiSelectComboBox()
    {
        InitializeComponent();
        _clb = new CheckedListBox
        {
            CheckOnClick = true,
            Width = 200,
            Height = 150,
            Font = new Font("Bosch Office Sans", 11F)
        };
        _clb.ItemCheck += UpdateText;

        _dropdown = new ToolStripDropDown();
        var host = new ToolStripControlHost(_clb);
        _dropdown.Items.Add(host);
    }

    private void UpdateText(object? sender, ItemCheckEventArgs e)
    {
        if(_isUpdating) return;
        _isUpdating = true;
        if (e.Index == 0)
        {
            _checkedItems.Clear();
            List<string> keys = _dataSource.Select(_ => _.Key).ToList();
            for (var i = 1; i < keys.Count + 1; i++)
            {
                _clb.SetItemCheckState(i, e.NewValue);
                if (e.NewValue == CheckState.Checked)
                    _checkedItems.Add(keys[i - 1]);
            }
        }
        else
        {
            var item = _clb.Items[e.Index] as string ?? "";
            if (e.NewValue == CheckState.Checked)
            {
                _checkedItems.Add(item);
            }
            else
            {
                _checkedItems.Remove(item);
            }
            CheckState chkAll = _checkedItems.Count == _dataSource.Count ? CheckState.Checked : _checkedItems.Count == 0 ? CheckState.Unchecked : CheckState.Indeterminate;
            _clb.SetItemCheckState(0, chkAll);
        }
        txtDisplay.Text = _checkedItems.Count > 2 ? $"selected {_checkedItems.Count}" : string.Join(", ", _checkedItems);
        _isUpdating=false;
    }

    private void btnDropdown_Click(object sender, EventArgs e)
    {
        if (!_dropdown.Visible)
            _dropdown.Show(this, new Point(0, this.Height));
    }
    public void SetDataSource(Dictionary<string, bool> dataSource)
    {
        _dataSource = dataSource;
        _checkedItems = _dataSource.Where(_ => _.Value == true).Select(_ => _.Key).ToList();
        _clb.Items.Clear();
        CheckState chkAll = dataSource.All(_ => _.Value == true) ? CheckState.Checked : dataSource.All(_ => _.Value == false) ? CheckState.Unchecked : CheckState.Indeterminate;
        _clb.Items.Add("All", chkAll);
        foreach (var item in dataSource)
        {
            _clb.Items.Add(item.Key, item.Value ? CheckState.Checked : CheckState.Unchecked);
        }
        
    }
    public List<object> GetSelectedItems() => _clb.CheckedItems.Cast<object>().ToList();
}
