namespace DISCPrinting.WinUI.Forms
{
    partial class TestPrintUC
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
            components = new System.ComponentModel.Container();
            lblPrintTemplate = new Label();
            cbPrintTemplate = new ComboBox();
            rtbData = new RichTextBox();
            lblPaperPrinter = new Label();
            cbPaperPrinter = new ComboBox();
            lblPaperType = new Label();
            lblData = new Label();
            cbPaperType = new ComboBox();
            lblWidth = new Label();
            txtPageWidth = new TextBox();
            txtPageHeight = new TextBox();
            lblHeight = new Label();
            ckLandscape = new CheckBox();
            lblLabelPrinter = new Label();
            cbLabelPrinter = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPrint = new Button();
            lblQuantity = new Label();
            txtQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblPrintTemplate
            // 
            lblPrintTemplate.AutoSize = true;
            lblPrintTemplate.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrintTemplate.Location = new Point(21, 0);
            lblPrintTemplate.Name = "lblPrintTemplate";
            lblPrintTemplate.Size = new Size(138, 22);
            lblPrintTemplate.TabIndex = 0;
            lblPrintTemplate.Text = "Print Template";
            // 
            // cbPrintTemplate
            // 
            tableLayoutPanel1.SetColumnSpan(cbPrintTemplate, 4);
            cbPrintTemplate.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPrintTemplate.FormattingEnabled = true;
            cbPrintTemplate.Location = new Point(167, 4);
            cbPrintTemplate.Margin = new Padding(3, 4, 3, 4);
            cbPrintTemplate.Name = "cbPrintTemplate";
            cbPrintTemplate.Size = new Size(412, 30);
            cbPrintTemplate.TabIndex = 1;
            cbPrintTemplate.SelectedIndexChanged += cbPrintTemplate_SelectedIndexChanged;
            // 
            // rtbData
            // 
            tableLayoutPanel1.SetColumnSpan(rtbData, 4);
            rtbData.Dock = DockStyle.Fill;
            rtbData.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbData.Location = new Point(167, 204);
            rtbData.Margin = new Padding(3, 4, 3, 4);
            rtbData.Name = "rtbData";
            rtbData.Size = new Size(412, 303);
            rtbData.TabIndex = 3;
            rtbData.Text = "";
            // 
            // lblPaperPrinter
            // 
            lblPaperPrinter.AutoSize = true;
            lblPaperPrinter.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaperPrinter.Location = new Point(21, 40);
            lblPaperPrinter.Name = "lblPaperPrinter";
            lblPaperPrinter.Size = new Size(128, 22);
            lblPaperPrinter.TabIndex = 0;
            lblPaperPrinter.Text = "Paper Printer";
            // 
            // cbPaperPrinter
            // 
            cbPaperPrinter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(cbPaperPrinter, 4);
            cbPaperPrinter.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaperPrinter.FormattingEnabled = true;
            cbPaperPrinter.Location = new Point(167, 44);
            cbPaperPrinter.Margin = new Padding(3, 4, 3, 4);
            cbPaperPrinter.Name = "cbPaperPrinter";
            cbPaperPrinter.Size = new Size(412, 30);
            cbPaperPrinter.TabIndex = 1;
            // 
            // lblPaperType
            // 
            lblPaperType.AutoSize = true;
            lblPaperType.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaperType.Location = new Point(21, 120);
            lblPaperType.Name = "lblPaperType";
            lblPaperType.Size = new Size(112, 22);
            lblPaperType.TabIndex = 0;
            lblPaperType.Text = "Paper Type";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(21, 200);
            lblData.Name = "lblData";
            lblData.Size = new Size(52, 22);
            lblData.TabIndex = 0;
            lblData.Text = "Data";
            // 
            // cbPaperType
            // 
            tableLayoutPanel1.SetColumnSpan(cbPaperType, 4);
            cbPaperType.Dock = DockStyle.Fill;
            cbPaperType.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaperType.FormattingEnabled = true;
            cbPaperType.Location = new Point(167, 124);
            cbPaperType.Margin = new Padding(3, 4, 3, 4);
            cbPaperType.Name = "cbPaperType";
            cbPaperType.Size = new Size(412, 30);
            cbPaperType.TabIndex = 1;
            cbPaperType.SelectedIndexChanged += cbPaperType_SelectedIndexChanged;
            // 
            // lblWidth
            // 
            lblWidth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWidth.Location = new Point(195, 160);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(67, 40);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "Width (in)";
            // 
            // txtPageWidth
            // 
            txtPageWidth.Dock = DockStyle.Fill;
            txtPageWidth.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPageWidth.Location = new Point(268, 164);
            txtPageWidth.Margin = new Padding(3, 4, 3, 4);
            txtPageWidth.Name = "txtPageWidth";
            txtPageWidth.Size = new Size(97, 30);
            txtPageWidth.TabIndex = 4;
            // 
            // txtPageHeight
            // 
            txtPageHeight.Dock = DockStyle.Fill;
            txtPageHeight.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPageHeight.Location = new Point(479, 164);
            txtPageHeight.Margin = new Padding(3, 4, 3, 4);
            txtPageHeight.Name = "txtPageHeight";
            txtPageHeight.Size = new Size(100, 30);
            txtPageHeight.TabIndex = 4;
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(371, 160);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(102, 22);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "Height (in)";
            // 
            // ckLandscape
            // 
            ckLandscape.AutoSize = true;
            ckLandscape.Enabled = false;
            ckLandscape.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckLandscape.Location = new Point(21, 164);
            ckLandscape.Margin = new Padding(3, 4, 3, 4);
            ckLandscape.Name = "ckLandscape";
            ckLandscape.Size = new Size(129, 26);
            ckLandscape.TabIndex = 5;
            ckLandscape.Text = "Landscape";
            ckLandscape.UseVisualStyleBackColor = true;
            // 
            // lblLabelPrinter
            // 
            lblLabelPrinter.AutoSize = true;
            lblLabelPrinter.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLabelPrinter.Location = new Point(21, 80);
            lblLabelPrinter.Name = "lblLabelPrinter";
            lblLabelPrinter.Size = new Size(123, 22);
            lblLabelPrinter.TabIndex = 0;
            lblLabelPrinter.Text = "Label Printer";
            // 
            // cbLabelPrinter
            // 
            tableLayoutPanel1.SetColumnSpan(cbLabelPrinter, 4);
            cbLabelPrinter.Dock = DockStyle.Fill;
            cbLabelPrinter.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLabelPrinter.FormattingEnabled = true;
            cbLabelPrinter.Location = new Point(167, 84);
            cbLabelPrinter.Margin = new Padding(3, 4, 3, 4);
            cbLabelPrinter.Name = "cbLabelPrinter";
            cbLabelPrinter.Size = new Size(412, 30);
            cbLabelPrinter.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.751582F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.55113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.21562F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.71977F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.76190472F));
            tableLayoutPanel1.Controls.Add(lblPrintTemplate, 1, 1);
            tableLayoutPanel1.Controls.Add(ckLandscape, 1, 5);
            tableLayoutPanel1.Controls.Add(txtPageWidth, 3, 5);
            tableLayoutPanel1.Controls.Add(txtPageHeight, 5, 5);
            tableLayoutPanel1.Controls.Add(lblPaperPrinter, 1, 2);
            tableLayoutPanel1.Controls.Add(lblLabelPrinter, 1, 3);
            tableLayoutPanel1.Controls.Add(lblPaperType, 1, 4);
            tableLayoutPanel1.Controls.Add(lblHeight, 4, 5);
            tableLayoutPanel1.Controls.Add(cbLabelPrinter, 2, 3);
            tableLayoutPanel1.Controls.Add(lblWidth, 2, 5);
            tableLayoutPanel1.Controls.Add(cbPaperType, 2, 4);
            tableLayoutPanel1.Controls.Add(cbPrintTemplate, 2, 1);
            tableLayoutPanel1.Controls.Add(lblData, 1, 6);
            tableLayoutPanel1.Controls.Add(cbPaperPrinter, 2, 2);
            tableLayoutPanel1.Controls.Add(rtbData, 2, 6);
            tableLayoutPanel1.Controls.Add(btnPrint, 5, 7);
            tableLayoutPanel1.Controls.Add(lblQuantity, 1, 7);
            tableLayoutPanel1.Controls.Add(txtQuantity, 2, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 311F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(603, 757);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(479, 514);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(21, 511);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(85, 22);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(167, 515);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(95, 30);
            txtQuantity.TabIndex = 7;
            // 
            // TestPrintUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TestPrintUC";
            Size = new Size(603, 757);
            Load += TestPrintUC_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPrintTemplate;
        private ComboBox cbPrintTemplate;
        private RichTextBox rtbData;
        private Label lblPaperPrinter;
        private ComboBox cbPaperPrinter;
        private Label lblPaperType;
        private Label lblData;
        private ComboBox cbPaperType;
        private Label lblWidth;
        private TextBox txtPageWidth;
        private TextBox txtPageHeight;
        private Label lblHeight;
        private CheckBox ckLandscape;
        private Label lblLabelPrinter;
        private ComboBox cbLabelPrinter;
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPrint;
        private Label lblQuantity;
        private NumericUpDown txtQuantity;
    }
}
