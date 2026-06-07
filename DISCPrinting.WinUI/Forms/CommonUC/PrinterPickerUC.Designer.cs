namespace DISCPrinting.WinUI.Forms
{
    partial class PrinterPickerUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpLayout = new TableLayoutPanel();
            label1 = new Label();
            cboPaperPrinter = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cboLabelPrinter = new ComboBox();
            tlpLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tlpLayout
            // 
            tlpLayout.BackColor = SystemColors.GradientInactiveCaption;
            tlpLayout.ColumnCount = 2;
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpLayout.Controls.Add(label1, 0, 0);
            tlpLayout.Controls.Add(cboPaperPrinter, 1, 1);
            tlpLayout.Controls.Add(label2, 0, 1);
            tlpLayout.Controls.Add(label3, 0, 2);
            tlpLayout.Controls.Add(cboLabelPrinter, 1, 2);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Location = new Point(0, 0);
            tlpLayout.Margin = new Padding(3, 2, 3, 2);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 3;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpLayout.Size = new Size(708, 112);
            tlpLayout.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tlpLayout.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 2);
            label1.Margin = new Padding(3, 2, 3, 2);
            label1.Name = "label1";
            label1.Size = new Size(702, 40);
            label1.TabIndex = 0;
            label1.Tag = "title left";
            label1.Text = "Printer Setting";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboPaperPrinter
            // 
            cboPaperPrinter.Dock = DockStyle.Fill;
            cboPaperPrinter.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPaperPrinter.FormattingEnabled = true;
            cboPaperPrinter.Location = new Point(215, 46);
            cboPaperPrinter.Margin = new Padding(3, 2, 9, 2);
            cboPaperPrinter.Name = "cboPaperPrinter";
            cboPaperPrinter.Size = new Size(484, 24);
            cboPaperPrinter.TabIndex = 1;
            cboPaperPrinter.SelectedIndexChanged += cboPaperPrinter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 0);
            label2.Size = new Size(206, 33);
            label2.TabIndex = 0;
            label2.Text = "Paper Printer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 77);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 0);
            label3.Size = new Size(206, 35);
            label3.TabIndex = 0;
            label3.Text = "Label Printer";
            // 
            // cboLabelPrinter
            // 
            cboLabelPrinter.Dock = DockStyle.Fill;
            cboLabelPrinter.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLabelPrinter.FormattingEnabled = true;
            cboLabelPrinter.Location = new Point(215, 79);
            cboLabelPrinter.Margin = new Padding(3, 2, 9, 2);
            cboLabelPrinter.Name = "cboLabelPrinter";
            cboLabelPrinter.Size = new Size(484, 24);
            cboLabelPrinter.TabIndex = 1;
            cboLabelPrinter.SelectedIndexChanged += cboLabelPrinter_SelectedIndexChanged;
            // 
            // PrinterPickerUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(tlpLayout);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PrinterPickerUC";
            Size = new Size(708, 112);
            tlpLayout.ResumeLayout(false);
            tlpLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private Label label1;
        private ComboBox cboPaperPrinter;
        private Label label2;
        private Label label3;
        private ComboBox cboLabelPrinter;
    }
}
