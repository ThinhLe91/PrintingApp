namespace DISCPrinting.WinUI.Forms
{
    partial class PrepareCoatingUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrepareCoatingUC));
            imageList1 = new ImageList(components);
            tlpCoatingBatchInfo = new TableLayoutPanel();
            lblCoatingBatchNumber = new Label();
            lblNewBatchInfo = new Label();
            txbCoatingBatchNo = new TextBox();
            lblCoatingArtical = new Label();
            txbCoatingArtical = new TextBox();
            lblCoatingQty = new Label();
            txbCoatingQty = new TextBox();
            tbcPrepareForCoating = new TabControl();
            tbpNewBatchPrepareCoating = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            printerPickeruc1 = new PrinterPickerUC();
            printCommanduc1 = new DISCPrinting.WinUI.Forms.CommonUC.PrintCommandUC();
            tbpHistoryPrepareCoating = new TabPage();
            tlpHistoryLayout = new TableLayoutPanel();
            tlpHistoryBatchInformation = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            btnHistorySearch = new Button();
            btnHistoryExportData = new Button();
            tlpHistoryPrintedBatches = new TableLayoutPanel();
            lblHistoryPrintedBatches = new Label();
            dgvPrepareCoatingList = new DataGridView();
            tlpCoatingBatchInfo.SuspendLayout();
            tbcPrepareForCoating.SuspendLayout();
            tbpNewBatchPrepareCoating.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tbpHistoryPrepareCoating.SuspendLayout();
            tlpHistoryLayout.SuspendLayout();
            tlpHistoryBatchInformation.SuspendLayout();
            tlpHistoryPrintedBatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrepareCoatingList).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ink_eraser_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(1, "print_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(2, "history_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(3, "new_window_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // tlpCoatingBatchInfo
            // 
            tlpCoatingBatchInfo.BackColor = SystemColors.GradientInactiveCaption;
            tlpCoatingBatchInfo.ColumnCount = 2;
            tlpCoatingBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4710732F));
            tlpCoatingBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.52892F));
            tlpCoatingBatchInfo.Controls.Add(lblCoatingBatchNumber, 0, 1);
            tlpCoatingBatchInfo.Controls.Add(lblNewBatchInfo, 0, 0);
            tlpCoatingBatchInfo.Controls.Add(txbCoatingBatchNo, 1, 1);
            tlpCoatingBatchInfo.Controls.Add(lblCoatingArtical, 0, 2);
            tlpCoatingBatchInfo.Controls.Add(txbCoatingArtical, 1, 2);
            tlpCoatingBatchInfo.Controls.Add(lblCoatingQty, 0, 3);
            tlpCoatingBatchInfo.Controls.Add(txbCoatingQty, 1, 3);
            tlpCoatingBatchInfo.Dock = DockStyle.Fill;
            tlpCoatingBatchInfo.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tlpCoatingBatchInfo.Location = new Point(10, 5);
            tlpCoatingBatchInfo.Name = "tlpCoatingBatchInfo";
            tlpCoatingBatchInfo.RowCount = 4;
            tlpCoatingBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853079F));
            tlpCoatingBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpCoatingBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpCoatingBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpCoatingBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpCoatingBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881622F));
            tlpCoatingBatchInfo.Size = new Size(719, 256);
            tlpCoatingBatchInfo.TabIndex = 18;
            tlpCoatingBatchInfo.Paint += tlpCoatingBatchInfo_Paint;
            // 
            // lblCoatingBatchNumber
            // 
            lblCoatingBatchNumber.AutoSize = true;
            lblCoatingBatchNumber.Dock = DockStyle.Fill;
            lblCoatingBatchNumber.Font = new Font("Bosch Office Sans", 10F);
            lblCoatingBatchNumber.Location = new Point(3, 64);
            lblCoatingBatchNumber.Name = "lblCoatingBatchNumber";
            lblCoatingBatchNumber.Padding = new Padding(0, 8, 0, 0);
            lblCoatingBatchNumber.Size = new Size(234, 63);
            lblCoatingBatchNumber.TabIndex = 12;
            lblCoatingBatchNumber.Text = "Batch ID";
            // 
            // lblNewBatchInfo
            // 
            lblNewBatchInfo.AutoSize = true;
            lblNewBatchInfo.BackColor = Color.Transparent;
            tlpCoatingBatchInfo.SetColumnSpan(lblNewBatchInfo, 2);
            lblNewBatchInfo.Dock = DockStyle.Fill;
            lblNewBatchInfo.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            lblNewBatchInfo.Location = new Point(4, 3);
            lblNewBatchInfo.Margin = new Padding(4, 3, 4, 3);
            lblNewBatchInfo.Name = "lblNewBatchInfo";
            lblNewBatchInfo.Size = new Size(711, 58);
            lblNewBatchInfo.TabIndex = 0;
            lblNewBatchInfo.Tag = "title left";
            lblNewBatchInfo.Text = "Batch Information";
            lblNewBatchInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbCoatingBatchNo
            // 
            txbCoatingBatchNo.Dock = DockStyle.Fill;
            txbCoatingBatchNo.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            txbCoatingBatchNo.Location = new Point(244, 67);
            txbCoatingBatchNo.Margin = new Padding(4, 3, 13, 3);
            txbCoatingBatchNo.Name = "txbCoatingBatchNo";
            txbCoatingBatchNo.Size = new Size(462, 30);
            txbCoatingBatchNo.TabIndex = 14;
            // 
            // lblCoatingArtical
            // 
            lblCoatingArtical.AutoSize = true;
            lblCoatingArtical.Dock = DockStyle.Fill;
            lblCoatingArtical.Font = new Font("Bosch Office Sans", 10F);
            lblCoatingArtical.Location = new Point(4, 130);
            lblCoatingArtical.Margin = new Padding(4, 3, 4, 3);
            lblCoatingArtical.Name = "lblCoatingArtical";
            lblCoatingArtical.Padding = new Padding(0, 8, 0, 0);
            lblCoatingArtical.Size = new Size(232, 57);
            lblCoatingArtical.TabIndex = 4;
            lblCoatingArtical.Text = "Artical No";
            // 
            // txbCoatingArtical
            // 
            txbCoatingArtical.Dock = DockStyle.Fill;
            txbCoatingArtical.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            txbCoatingArtical.Location = new Point(244, 130);
            txbCoatingArtical.Margin = new Padding(4, 3, 13, 3);
            txbCoatingArtical.Name = "txbCoatingArtical";
            txbCoatingArtical.Size = new Size(462, 30);
            txbCoatingArtical.TabIndex = 10;
            // 
            // lblCoatingQty
            // 
            lblCoatingQty.AutoSize = true;
            lblCoatingQty.Dock = DockStyle.Fill;
            lblCoatingQty.Font = new Font("Bosch Office Sans", 10F);
            lblCoatingQty.Location = new Point(3, 190);
            lblCoatingQty.Name = "lblCoatingQty";
            lblCoatingQty.Padding = new Padding(0, 8, 0, 0);
            lblCoatingQty.Size = new Size(234, 66);
            lblCoatingQty.TabIndex = 5;
            lblCoatingQty.Text = "Quantity";
            // 
            // txbCoatingQty
            // 
            txbCoatingQty.Dock = DockStyle.Fill;
            txbCoatingQty.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            txbCoatingQty.Location = new Point(244, 193);
            txbCoatingQty.Margin = new Padding(4, 3, 13, 3);
            txbCoatingQty.Name = "txbCoatingQty";
            txbCoatingQty.Size = new Size(462, 30);
            txbCoatingQty.TabIndex = 11;
            // 
            // tbcPrepareForCoating
            // 
            tbcPrepareForCoating.Controls.Add(tbpNewBatchPrepareCoating);
            tbcPrepareForCoating.Controls.Add(tbpHistoryPrepareCoating);
            tbcPrepareForCoating.Dock = DockStyle.Fill;
            tbcPrepareForCoating.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            tbcPrepareForCoating.ImageList = imageList1;
            tbcPrepareForCoating.ItemSize = new Size(113, 33);
            tbcPrepareForCoating.Location = new Point(0, 0);
            tbcPrepareForCoating.Name = "tbcPrepareForCoating";
            tbcPrepareForCoating.SelectedIndex = 0;
            tbcPrepareForCoating.Size = new Size(754, 947);
            tbcPrepareForCoating.TabIndex = 19;
            // 
            // tbpNewBatchPrepareCoating
            // 
            tbpNewBatchPrepareCoating.Controls.Add(tableLayoutPanel4);
            tbpNewBatchPrepareCoating.Font = new Font("Bosch Office Sans", 10F);
            tbpNewBatchPrepareCoating.ImageIndex = 3;
            tbpNewBatchPrepareCoating.Location = new Point(4, 37);
            tbpNewBatchPrepareCoating.Name = "tbpNewBatchPrepareCoating";
            tbpNewBatchPrepareCoating.Padding = new Padding(3, 3, 3, 3);
            tbpNewBatchPrepareCoating.Size = new Size(746, 906);
            tbpNewBatchPrepareCoating.TabIndex = 0;
            tbpNewBatchPrepareCoating.Text = "New Batch";
            tbpNewBatchPrepareCoating.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel4.Controls.Add(tlpCoatingBatchInfo, 1, 1);
            tableLayoutPanel4.Controls.Add(printerPickeruc1, 1, 3);
            tableLayoutPanel4.Controls.Add(printCommanduc1, 1, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 1.0524981F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 97.8950043F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 205F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 242F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 1.0524981F));
            tableLayoutPanel4.Size = new Size(740, 900);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // printerPickeruc1
            // 
            printerPickeruc1.BackColor = Color.LightSteelBlue;
            printerPickeruc1.Dock = DockStyle.Fill;
            printerPickeruc1.Location = new Point(11, 472);
            printerPickeruc1.Margin = new Padding(4, 3, 4, 3);
            printerPickeruc1.Name = "printerPickeruc1";
            printerPickeruc1.Size = new Size(717, 236);
            printerPickeruc1.TabIndex = 19;
            // 
            // printCommanduc1
            // 
            printCommanduc1.Dock = DockStyle.Fill;
            printCommanduc1.Location = new Point(11, 811);
            printCommanduc1.Margin = new Padding(4, 3, 4, 3);
            printCommanduc1.Name = "printCommanduc1";
            printCommanduc1.Size = new Size(717, 82);
            printCommanduc1.TabIndex = 20;
            // 
            // tbpHistoryPrepareCoating
            // 
            tbpHistoryPrepareCoating.Controls.Add(tlpHistoryLayout);
            tbpHistoryPrepareCoating.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            tbpHistoryPrepareCoating.ImageIndex = 2;
            tbpHistoryPrepareCoating.Location = new Point(4, 37);
            tbpHistoryPrepareCoating.Name = "tbpHistoryPrepareCoating";
            tbpHistoryPrepareCoating.Padding = new Padding(3, 3, 3, 3);
            tbpHistoryPrepareCoating.Size = new Size(746, 906);
            tbpHistoryPrepareCoating.TabIndex = 1;
            tbpHistoryPrepareCoating.Text = "History";
            tbpHistoryPrepareCoating.UseVisualStyleBackColor = true;
            // 
            // tlpHistoryLayout
            // 
            tlpHistoryLayout.ColumnCount = 3;
            tlpHistoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpHistoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tlpHistoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpHistoryLayout.Controls.Add(tlpHistoryBatchInformation, 1, 1);
            tlpHistoryLayout.Controls.Add(btnHistoryExportData, 1, 5);
            tlpHistoryLayout.Controls.Add(tlpHistoryPrintedBatches, 1, 3);
            tlpHistoryLayout.Dock = DockStyle.Fill;
            tlpHistoryLayout.Location = new Point(3, 3);
            tlpHistoryLayout.Margin = new Padding(4, 3, 4, 3);
            tlpHistoryLayout.Name = "tlpHistoryLayout";
            tlpHistoryLayout.RowCount = 7;
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 0.75757575F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20.28169F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.577465F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 53.5211258F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5.07042265F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.859155F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 0.75757575F));
            tlpHistoryLayout.Size = new Size(740, 900);
            tlpHistoryLayout.TabIndex = 32;
            tlpHistoryLayout.Tag = "title center";
            // 
            // tlpHistoryBatchInformation
            // 
            tlpHistoryBatchInformation.BackColor = SystemColors.GradientInactiveCaption;
            tlpHistoryBatchInformation.ColumnCount = 2;
            tlpHistoryBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4710732F));
            tlpHistoryBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.52892F));
            tlpHistoryBatchInformation.Controls.Add(label2, 0, 1);
            tlpHistoryBatchInformation.Controls.Add(label3, 0, 0);
            tlpHistoryBatchInformation.Controls.Add(textBox1, 1, 1);
            tlpHistoryBatchInformation.Controls.Add(btnHistorySearch, 1, 2);
            tlpHistoryBatchInformation.Dock = DockStyle.Fill;
            tlpHistoryBatchInformation.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tlpHistoryBatchInformation.Location = new Point(10, 9);
            tlpHistoryBatchInformation.Name = "tlpHistoryBatchInformation";
            tlpHistoryBatchInformation.RowCount = 3;
            tlpHistoryBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 32.35294F));
            tlpHistoryBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 29.710144F));
            tlpHistoryBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 38.4057961F));
            tlpHistoryBatchInformation.Size = new Size(719, 176);
            tlpHistoryBatchInformation.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bosch Office Sans", 10F);
            label2.Location = new Point(4, 59);
            label2.Margin = new Padding(4, 3, 4, 3);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 8, 0, 0);
            label2.Size = new Size(232, 46);
            label2.TabIndex = 12;
            label2.Text = "Batch ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            tlpHistoryBatchInformation.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            label3.Location = new Point(4, 3);
            label3.Margin = new Padding(4, 3, 4, 3);
            label3.Name = "label3";
            label3.Size = new Size(711, 50);
            label3.TabIndex = 0;
            label3.Tag = "title left";
            label3.Text = "Batch Information";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            textBox1.Location = new Point(243, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 30);
            textBox1.TabIndex = 14;
            // 
            // btnHistorySearch
            // 
            btnHistorySearch.Dock = DockStyle.Top;
            btnHistorySearch.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            btnHistorySearch.ForeColor = SystemColors.ControlText;
            btnHistorySearch.Location = new Point(243, 111);
            btnHistorySearch.Name = "btnHistorySearch";
            btnHistorySearch.Size = new Size(473, 2);
            btnHistorySearch.TabIndex = 20;
            btnHistorySearch.Text = "Search";
            btnHistorySearch.UseVisualStyleBackColor = true;
            // 
            // btnHistoryExportData
            // 
            btnHistoryExportData.Dock = DockStyle.Top;
            btnHistoryExportData.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            btnHistoryExportData.ForeColor = SystemColors.ControlText;
            btnHistoryExportData.Location = new Point(14, 809);
            btnHistoryExportData.Margin = new Padding(7, 8, 7, 8);
            btnHistoryExportData.Name = "btnHistoryExportData";
            btnHistoryExportData.Size = new Size(711, 2);
            btnHistoryExportData.TabIndex = 31;
            btnHistoryExportData.Text = "Export Data";
            btnHistoryExportData.UseVisualStyleBackColor = true;
            // 
            // tlpHistoryPrintedBatches
            // 
            tlpHistoryPrintedBatches.BackColor = SystemColors.GradientInactiveCaption;
            tlpHistoryPrintedBatches.ColumnCount = 1;
            tlpHistoryPrintedBatches.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryPrintedBatches.Controls.Add(lblHistoryPrintedBatches, 0, 0);
            tlpHistoryPrintedBatches.Controls.Add(dgvPrepareCoatingList, 0, 1);
            tlpHistoryPrintedBatches.Dock = DockStyle.Fill;
            tlpHistoryPrintedBatches.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tlpHistoryPrintedBatches.Location = new Point(10, 277);
            tlpHistoryPrintedBatches.Name = "tlpHistoryPrintedBatches";
            tlpHistoryPrintedBatches.RowCount = 2;
            tlpHistoryPrintedBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpHistoryPrintedBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 87.5F));
            tlpHistoryPrintedBatches.Size = new Size(719, 476);
            tlpHistoryPrintedBatches.TabIndex = 26;
            // 
            // lblHistoryPrintedBatches
            // 
            lblHistoryPrintedBatches.AutoSize = true;
            tlpHistoryPrintedBatches.SetColumnSpan(lblHistoryPrintedBatches, 2);
            lblHistoryPrintedBatches.Dock = DockStyle.Fill;
            lblHistoryPrintedBatches.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            lblHistoryPrintedBatches.Location = new Point(4, 3);
            lblHistoryPrintedBatches.Margin = new Padding(4, 3, 4, 3);
            lblHistoryPrintedBatches.Name = "lblHistoryPrintedBatches";
            lblHistoryPrintedBatches.Size = new Size(711, 53);
            lblHistoryPrintedBatches.TabIndex = 1;
            lblHistoryPrintedBatches.Tag = "title left";
            lblHistoryPrintedBatches.Text = "Printed Batches";
            lblHistoryPrintedBatches.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvPrepareCoatingList
            // 
            dgvPrepareCoatingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrepareCoatingList.Dock = DockStyle.Fill;
            dgvPrepareCoatingList.Location = new Point(3, 62);
            dgvPrepareCoatingList.Name = "dgvPrepareCoatingList";
            dgvPrepareCoatingList.RowHeadersWidth = 62;
            dgvPrepareCoatingList.Size = new Size(713, 411);
            dgvPrepareCoatingList.TabIndex = 0;
            // 
            // PrepareCoatingUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcPrepareForCoating);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PrepareCoatingUC";
            Size = new Size(754, 947);
            tlpCoatingBatchInfo.ResumeLayout(false);
            tlpCoatingBatchInfo.PerformLayout();
            tbcPrepareForCoating.ResumeLayout(false);
            tbpNewBatchPrepareCoating.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tbpHistoryPrepareCoating.ResumeLayout(false);
            tlpHistoryLayout.ResumeLayout(false);
            tlpHistoryBatchInformation.ResumeLayout(false);
            tlpHistoryBatchInformation.PerformLayout();
            tlpHistoryPrintedBatches.ResumeLayout(false);
            tlpHistoryPrintedBatches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrepareCoatingList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TableLayoutPanel tlpCoatingBatchInfo;
        private Label lblCoatingBatchNumber;
        private Label lblNewBatchInfo;
        private TextBox txbCoatingBatchNo;
        private Label lblCoatingArtical;
        private TextBox txbCoatingArtical;
        private Label lblCoatingQty;
        private TextBox txbCoatingQty;
        private TabControl tbcPrepareForCoating;
        private TabPage tbpNewBatchPrepareCoating;
        private TabPage tbpHistoryPrepareCoating;
        private TableLayoutPanel tlpHistoryPrintedBatches;
        private DataGridView dgvPrepareCoatingList;
        private TableLayoutPanel tlpHistoryBatchInformation;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button btnHistorySearch;
        private Button btnHistoryExportData;
        private TableLayoutPanel tableLayoutPanel4;
        private PrinterPickerUC printerPickeruc1;
        private CommonUC.PrintCommandUC printCommanduc1;
        private TableLayoutPanel tlpHistoryLayout;
        private Label lblHistoryPrintedBatches;
    }
}
