namespace DISCPrinting.WinUI.Forms;

public class NormalTheme
{
    private static readonly Dictionary<string, Action<Control>> StyleActions = new()
    {
        { "title",  c => c.Font = ThemeFont.Title },
        { "header", c => c.Font = ThemeFont.Header },
        { "italic", c => c.Font = ThemeFont.Italic },
        { "btn-lg", c => c.Font = ThemeFont.LgBtn },

        { "center", c => { if (c is Label l) l.TextAlign = ContentAlignment.MiddleCenter; } },
        { "right",  c => { if (c is Label l) l.TextAlign = ContentAlignment.MiddleRight; } },
        { "left",   c => { if (c is Label l) l.TextAlign = ContentAlignment.MiddleLeft; } }
    }; 

    public class ThemeFont
    {
        public static Font Normal = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        public static Font Title = new Font("Bosch Office Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        public static Font Italic = new Font("Bosch Office Sans", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
        public static Font Header = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        public static Font Btn = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        public static Font LgBtn = new Font("Bosch Office Sans", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
    }

    public static void Apply(Control.ControlCollection controls)
    {
        foreach (Control control in controls)
        {
            control.Font = ThemeFont.Normal;
            if (control is Label lbl && lbl.Tag == null)
            {
                control.Padding = new Padding(0, 7, 0, 0);
            }
            else if (control is Button btn && btn.Tag == null)
            {
                control.Font = ThemeFont.Btn;
            }
            var styles = control.Tag?.ToString() ?? "";
            if (!string.IsNullOrEmpty(styles))
            {
                foreach (var style in styles.ToLower().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if(StyleActions.TryGetValue(style, out var action))
                        action(control);
                }
            }
            if (control.HasChildren)
                Apply(control.Controls);
        }

    }
}
