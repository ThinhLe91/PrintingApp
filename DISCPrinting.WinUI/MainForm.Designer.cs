namespace WinFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip2 = new StatusStrip();
            lblSpacer = new ToolStripStatusLabel();
            lblVersion = new ToolStripStatusLabel();
            HeaderPanel = new Panel();
            MainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new ToolStripItem[] { lblSpacer, lblVersion });
            statusStrip2.Location = new Point(0, 639);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(534, 22);
            statusStrip2.TabIndex = 2;
            statusStrip2.Text = "statusStrip2";
            // 
            // lblSpacer
            // 
            lblSpacer.Name = "lblSpacer";
            lblSpacer.Size = new Size(440, 17);
            lblSpacer.Spring = true;
            lblSpacer.Text = "Designed, Develop By HcP/ICO3";
            lblSpacer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Bosch Office Sans", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(79, 17);
            lblVersion.Text = "Version 0.0.0";
            // 
            // HeaderPanel
            // 
            HeaderPanel.Dock = DockStyle.Fill;
            HeaderPanel.Location = new Point(3, 3);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(528, 64);
            HeaderPanel.TabIndex = 3;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 73);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(528, 568);
            MainPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(MainPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(HeaderPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(534, 639);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 661);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DISC - Printing Application";
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel lblSpacer;
        private ToolStripStatusLabel lblVersion;
        private Panel HeaderPanel;
        private Panel MainPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
