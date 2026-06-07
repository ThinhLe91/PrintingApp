namespace DISCPrinting.WinUI.Forms;

public partial class BatchPickerUC : UserControl
{
    public event Action<List<int>>? BatchSelectionChanged;
    private List<int> _batches = new List<int>();
    private bool _isUpdating = false;
    public BatchPickerUC()
    {
        InitializeComponent();
    }

    private void CheckedChangeHandle(object sender, EventArgs e)
    {
        if (_isUpdating) return;
        _isUpdating = true;
        if (sender == ckbBatchAll)
        {
            _batches = ckbBatchAll.Checked ? Enumerable.Range(1, 5).ToList() : new List<int>();
            ckbBatch1.Checked = ckbBatchAll.Checked;
            ckbBatch2.Checked = ckbBatchAll.Checked;
            ckbBatch3.Checked = ckbBatchAll.Checked;
            ckbBatch4.Checked = ckbBatchAll.Checked;
            ckbBatch5.Checked = ckbBatchAll.Checked;
        }
        else
        {
            _batches.Clear();
            if (ckbBatch1.Checked) _batches.Add(1);
            if (ckbBatch2.Checked) _batches.Add(2);
            if (ckbBatch3.Checked) _batches.Add(3);
            if (ckbBatch4.Checked) _batches.Add(4);
            if (ckbBatch5.Checked) _batches.Add(5);
            ckbBatchAll.CheckState = _batches.Count == 5 ? CheckState.Checked : _batches.Count == 0 ? CheckState.Unchecked : CheckState.Indeterminate;
        }
        _isUpdating = false;
        BatchSelectionChanged?.Invoke(_batches);
    }

    private void ckbBatchAll_CheckedChanged(object sender, EventArgs e)
    {

    }
}
