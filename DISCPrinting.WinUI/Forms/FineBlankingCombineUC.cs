using Microsoft.Extensions.DependencyInjection;
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

public partial class FineBlankingCombineUC : BaseUserControl
{
    public override string PageTitle => "Fine Blanking && Deburring";
    public FineBlankingCombineUC(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
        InitializeComponent();
    }
}
