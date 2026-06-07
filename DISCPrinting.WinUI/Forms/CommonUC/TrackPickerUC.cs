using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCPrinting.WinUI.Forms;

public partial class TrackPickerUC : UserControl
{
    public event Action<List<int>>? TrackSelectionChanged;
    private List<int> _tracks = new List<int>();
    public TrackPickerUC()
    {
        InitializeComponent();
    }

    private void CheckedChangeHandle(object sender, EventArgs e)
    {
        _tracks.Clear();
        if (ckbTrack1.Checked) _tracks.Add(1);
        if (ckbTrack2.Checked) _tracks.Add(2);
        if (ckbTrack3.Checked) _tracks.Add(3);
        if (ckbTrack4.Checked) _tracks.Add(4);
        TrackSelectionChanged?.Invoke(_tracks);
    }

    public void SetEnable(bool enable, List<int>? tracks = null)
    {
        if (tracks == null)
        {
            tracks = Enumerable.Range(1, 4).ToList();
        }
        if (tracks.Contains(1)) ckbTrack1.Enabled = enable;
        if (tracks.Contains(2)) ckbTrack2.Enabled = enable;
        if (tracks.Contains(3)) ckbTrack3.Enabled = enable;
        if (tracks.Contains(4)) ckbTrack4.Enabled = enable;
    }

    public void SetChecked(bool isCheck, List<int>? tracks = null)
    {
        if (tracks == null)
        {
            tracks = Enumerable.Range(1, 4).ToList();
        }
        if (tracks.Contains(1)) ckbTrack1.Checked = isCheck;
        if (tracks.Contains(2)) ckbTrack2.Checked = isCheck;
        if (tracks.Contains(3)) ckbTrack3.Checked = isCheck;
        if (tracks.Contains(4)) ckbTrack4.Checked = isCheck;
    }
}
