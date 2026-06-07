namespace DISCPrinting.WinUI.Forms
{
    partial class AOIUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AOIUC));
            imageList1 = new ImageList(components);
            tlpAOIBatchInfo = new TableLayoutPanel();
            lblBatchNumberAOI = new Label();
            lblNewBatchInfoAOI = new Label();
            txbNewBatchNoAOI = new TextBox();
            lblArticalAOI = new Label();
            txbNewArticalAO = new TextBox();
            lblQtyAOI = new Label();
            txbNewQtyAOI = new TextBox();
            tbcAOI = new TabControl();
            tbpAOINewBox = new TabPage();
            tlpBatchInformation = new TableLayoutPanel();
            printCommanduc1 = new DISCPrinting.WinUI.Forms.CommonUC.PrintCommandUC();
            printerPicker = new PrinterPickerUC();
            tbpAOIBoxHistory = new TabPage();
            tableHistoryLayout = new TableLayoutPanel();
            btnHistoryExportData = new Button();
            tlpHistoryPrintedBoxes = new TableLayoutPanel();
            lblHistoryPrintedBoxes = new Label();
            dgvHistoryPrintedBoxes = new DataGridView();
            tlpHistoryBatchInformation = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtHistoryBatchId = new TextBox();
            btnHistorySearch = new Button();
            tlpAOIBatchInfo.SuspendLayout();
            tbcAOI.SuspendLayout();
            tbpAOINewBox.SuspendLayout();
            tlpBatchInformation.SuspendLayout();
            tbpAOIBoxHistory.SuspendLayout();
            tableHistoryLayout.SuspendLayout();
            tlpHistoryPrintedBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryPrintedBoxes).BeginInit();
            tlpHistoryBatchInformation.SuspendLayout();
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
            // tlpAOIBatchInfo
            // 
            tlpAOIBatchInfo.BackColor = SystemColors.GradientInactiveCaption;
            tlpAOIBatchInfo.ColumnCount = 2;
            tlpAOIBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpAOIBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpAOIBatchInfo.Controls.Add(lblBatchNumberAOI, 0, 1);
            tlpAOIBatchInfo.Controls.Add(lblNewBatchInfoAOI, 0, 0);
            tlpAOIBatchInfo.Controls.Add(txbNewBatchNoAOI, 1, 1);
            tlpAOIBatchInfo.Controls.Add(lblArticalAOI, 0, 2);
            tlpAOIBatchInfo.Controls.Add(txbNewArticalAO, 1, 2);
            tlpAOIBatchInfo.Controls.Add(lblQtyAOI, 0, 3);
            tlpAOIBatchInfo.Controls.Add(txbNewQtyAOI, 1, 3);
            tlpAOIBatchInfo.Dock = DockStyle.Fill;
            tlpAOIBatchInfo.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tlpAOIBatchInfo.Location = new Point(7, 23);
            tlpAOIBatchInfo.Margin = new Padding(2, 3, 2, 3);
            tlpAOIBatchInfo.Name = "tlpAOIBatchInfo";
            tlpAOIBatchInfo.RowCount = 4;
            tlpAOIBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpAOIBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpAOIBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpAOIBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpAOIBatchInfo.Size = new Size(575, 209);
            tlpAOIBatchInfo.TabIndex = 20;
            // 
            // lblBatchNumberAOI
            // 
            lblBatchNumberAOI.AutoSize = true;
            lblBatchNumberAOI.Dock = DockStyle.Fill;
            lblBatchNumberAOI.Font = new Font("Bosch Office Sans", 10F);
            lblBatchNumberAOI.Location = new Point(3, 55);
            lblBatchNumberAOI.Margin = new Padding(3);
            lblBatchNumberAOI.Name = "lblBatchNumberAOI";
            lblBatchNumberAOI.Padding = new Padding(0, 7, 0, 0);
            lblBatchNumberAOI.Size = new Size(224, 46);
            lblBatchNumberAOI.TabIndex = 12;
            lblBatchNumberAOI.Text = "Batch ID";
            // 
            // lblNewBatchInfoAOI
            // 
            lblNewBatchInfoAOI.AutoSize = true;
            tlpAOIBatchInfo.SetColumnSpan(lblNewBatchInfoAOI, 2);
            lblNewBatchInfoAOI.Dock = DockStyle.Fill;
            lblNewBatchInfoAOI.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            lblNewBatchInfoAOI.Location = new Point(3, 3);
            lblNewBatchInfoAOI.Margin = new Padding(3);
            lblNewBatchInfoAOI.Name = "lblNewBatchInfoAOI";
            lblNewBatchInfoAOI.Size = new Size(569, 46);
            lblNewBatchInfoAOI.TabIndex = 0;
            lblNewBatchInfoAOI.Tag = "title left";
            lblNewBatchInfoAOI.Text = "Batch Information";
            lblNewBatchInfoAOI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbNewBatchNoAOI
            // 
            txbNewBatchNoAOI.Dock = DockStyle.Fill;
            txbNewBatchNoAOI.Location = new Point(233, 55);
            txbNewBatchNoAOI.Margin = new Padding(3, 3, 10, 3);
            txbNewBatchNoAOI.Name = "txbNewBatchNoAOI";
            txbNewBatchNoAOI.Size = new Size(332, 26);
            txbNewBatchNoAOI.TabIndex = 14;
            // 
            // lblArticalAOI
            // 
            lblArticalAOI.AutoSize = true;
            lblArticalAOI.Dock = DockStyle.Fill;
            lblArticalAOI.Font = new Font("Bosch Office Sans", 10F);
            lblArticalAOI.Location = new Point(3, 107);
            lblArticalAOI.Margin = new Padding(3);
            lblArticalAOI.Name = "lblArticalAOI";
            lblArticalAOI.Padding = new Padding(0, 7, 0, 0);
            lblArticalAOI.Size = new Size(224, 46);
            lblArticalAOI.TabIndex = 4;
            lblArticalAOI.Text = "Artical No";
            // 
            // txbNewArticalAO
            // 
            txbNewArticalAO.Dock = DockStyle.Fill;
            txbNewArticalAO.Location = new Point(233, 107);
            txbNewArticalAO.Margin = new Padding(3, 3, 10, 3);
            txbNewArticalAO.Name = "txbNewArticalAO";
            txbNewArticalAO.Size = new Size(332, 26);
            txbNewArticalAO.TabIndex = 10;
            // 
            // lblQtyAOI
            // 
            lblQtyAOI.AutoSize = true;
            lblQtyAOI.Dock = DockStyle.Fill;
            lblQtyAOI.Font = new Font("Bosch Office Sans", 10F);
            lblQtyAOI.Location = new Point(3, 159);
            lblQtyAOI.Margin = new Padding(3);
            lblQtyAOI.Name = "lblQtyAOI";
            lblQtyAOI.Padding = new Padding(0, 7, 0, 0);
            lblQtyAOI.Size = new Size(224, 47);
            lblQtyAOI.TabIndex = 5;
            lblQtyAOI.Text = "Quantity";
            // 
            // txbNewQtyAOI
            // 
            txbNewQtyAOI.Dock = DockStyle.Fill;
            txbNewQtyAOI.Location = new Point(233, 159);
            txbNewQtyAOI.Margin = new Padding(3, 3, 10, 3);
            txbNewQtyAOI.Name = "txbNewQtyAOI";
            txbNewQtyAOI.Size = new Size(332, 26);
            txbNewQtyAOI.TabIndex = 11;
            // 
            // tbcAOI
            // 
            tbcAOI.Controls.Add(tbpAOINewBox);
            tbcAOI.Controls.Add(tbpAOIBoxHistory);
            tbcAOI.Dock = DockStyle.Fill;
            tbcAOI.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            tbcAOI.ImageList = imageList1;
            tbcAOI.ItemSize = new Size(113, 33);
            tbcAOI.Location = new Point(0, 0);
            tbcAOI.Margin = new Padding(2, 3, 2, 3);
            tbcAOI.Name = "tbcAOI";
            tbcAOI.SelectedIndex = 0;
            tbcAOI.Size = new Size(603, 757);
            tbcAOI.TabIndex = 23;
            // 
            // tbpAOINewBox
            // 
            tbpAOINewBox.Controls.Add(tlpBatchInformation);
            tbpAOINewBox.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            tbpAOINewBox.ImageIndex = 3;
            tbpAOINewBox.Location = new Point(4, 37);
            tbpAOINewBox.Margin = new Padding(2, 3, 2, 3);
            tbpAOINewBox.Name = "tbpAOINewBox";
            tbpAOINewBox.Padding = new Padding(2, 3, 2, 3);
            tbpAOINewBox.Size = new Size(595, 716);
            tbpAOINewBox.TabIndex = 0;
            tbpAOINewBox.Text = "New Box";
            tbpAOINewBox.UseVisualStyleBackColor = true;
            // 
            // tlpBatchInformation
            // 
            tlpBatchInformation.ColumnCount = 3;
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpBatchInformation.Controls.Add(tlpAOIBatchInfo, 1, 1);
            tlpBatchInformation.Controls.Add(printCommanduc1, 1, 5);
            tlpBatchInformation.Controls.Add(printerPicker, 1, 3);
            tlpBatchInformation.Dock = DockStyle.Fill;
            tlpBatchInformation.Location = new Point(2, 3);
            tlpBatchInformation.Name = "tlpBatchInformation";
            tlpBatchInformation.RowCount = 7;
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 8.62423F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 91.37577F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 164F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpBatchInformation.Size = new Size(591, 710);
            tlpBatchInformation.TabIndex = 21;
            // 
            // printCommanduc1
            // 
            printCommanduc1.Dock = DockStyle.Fill;
            printCommanduc1.Location = new Point(8, 593);
            printCommanduc1.Name = "printCommanduc1";
            printCommanduc1.Size = new Size(573, 74);
            printCommanduc1.TabIndex = 21;
            // 
            // printerPicker
            // 
            printerPicker.BackColor = Color.LightSteelBlue;
            printerPicker.Dock = DockStyle.Fill;
            printerPicker.Location = new Point(8, 344);
            printerPicker.Name = "printerPicker";
            printerPicker.Size = new Size(573, 158);
            printerPicker.TabIndex = 22;
            // 
            // tbpAOIBoxHistory
            // 
            tbpAOIBoxHistory.Controls.Add(tableHistoryLayout);
            tbpAOIBoxHistory.ImageIndex = 2;
            tbpAOIBoxHistory.Location = new Point(4, 37);
            tbpAOIBoxHistory.Margin = new Padding(2, 3, 2, 3);
            tbpAOIBoxHistory.Name = "tbpAOIBoxHistory";
            tbpAOIBoxHistory.Padding = new Padding(2, 3, 2, 3);
            tbpAOIBoxHistory.Size = new Size(595, 716);
            tbpAOIBoxHistory.TabIndex = 1;
            tbpAOIBoxHistory.Text = "History";
            tbpAOIBoxHistory.UseVisualStyleBackColor = true;
            // 
            // tableHistoryLayout
            // 
            tableHistoryLayout.ColumnCount = 1;
            tableHistoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableHistoryLayout.Controls.Add(btnHistoryExportData, 0, 5);
            tableHistoryLayout.Controls.Add(tlpHistoryPrintedBoxes, 0, 3);
            tableHistoryLayout.Controls.Add(tlpHistoryBatchInformation, 0, 1);
            tableHistoryLayout.Dock = DockStyle.Fill;
            tableHistoryLayout.Location = new Point(2, 3);
            tableHistoryLayout.Name = "tableHistoryLayout";
            tableHistoryLayout.RowCount = 7;
            tableHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 3.97111917F));
            tableHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 96.02888F));
            tableHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 294F));
            tableHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableHistoryLayout.Size = new Size(591, 710);
            tableHistoryLayout.TabIndex = 31;
            // 
            // btnHistoryExportData
            // 
            btnHistoryExportData.Dock = DockStyle.Fill;
            btnHistoryExportData.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            btnHistoryExportData.ForeColor = SystemColors.ControlText;
            btnHistoryExportData.Location = new Point(3, 634);
            btnHistoryExportData.Margin = new Padding(3, 4, 3, 4);
            btnHistoryExportData.Name = "btnHistoryExportData";
            btnHistoryExportData.Size = new Size(585, 51);
            btnHistoryExportData.TabIndex = 30;
            btnHistoryExportData.Text = "Export Data";
            btnHistoryExportData.UseVisualStyleBackColor = true;
            // 
            // tlpHistoryPrintedBoxes
            // 
            tlpHistoryPrintedBoxes.BackColor = SystemColors.GradientInactiveCaption;
            tlpHistoryPrintedBoxes.ColumnCount = 1;
            tlpHistoryPrintedBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryPrintedBoxes.Controls.Add(lblHistoryPrintedBoxes, 0, 0);
            tlpHistoryPrintedBoxes.Controls.Add(dgvHistoryPrintedBoxes, 0, 1);
            tlpHistoryPrintedBoxes.Dock = DockStyle.Fill;
            tlpHistoryPrintedBoxes.Location = new Point(2, 266);
            tlpHistoryPrintedBoxes.Margin = new Padding(2, 3, 2, 3);
            tlpHistoryPrintedBoxes.Name = "tlpHistoryPrintedBoxes";
            tlpHistoryPrintedBoxes.RowCount = 2;
            tlpHistoryPrintedBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tlpHistoryPrintedBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tlpHistoryPrintedBoxes.Size = new Size(587, 288);
            tlpHistoryPrintedBoxes.TabIndex = 23;
            // 
            // lblHistoryPrintedBoxes
            // 
            lblHistoryPrintedBoxes.AutoSize = true;
            tlpHistoryPrintedBoxes.SetColumnSpan(lblHistoryPrintedBoxes, 2);
            lblHistoryPrintedBoxes.Dock = DockStyle.Fill;
            lblHistoryPrintedBoxes.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            lblHistoryPrintedBoxes.Location = new Point(3, 3);
            lblHistoryPrintedBoxes.Margin = new Padding(3);
            lblHistoryPrintedBoxes.Name = "lblHistoryPrintedBoxes";
            lblHistoryPrintedBoxes.Size = new Size(581, 76);
            lblHistoryPrintedBoxes.TabIndex = 1;
            lblHistoryPrintedBoxes.Tag = "title left";
            lblHistoryPrintedBoxes.Text = "Printed Boxes";
            lblHistoryPrintedBoxes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvHistoryPrintedBoxes
            // 
            dgvHistoryPrintedBoxes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryPrintedBoxes.Dock = DockStyle.Fill;
            dgvHistoryPrintedBoxes.Location = new Point(2, 85);
            dgvHistoryPrintedBoxes.Margin = new Padding(2, 3, 2, 3);
            dgvHistoryPrintedBoxes.Name = "dgvHistoryPrintedBoxes";
            dgvHistoryPrintedBoxes.RowHeadersWidth = 62;
            dgvHistoryPrintedBoxes.Size = new Size(583, 200);
            dgvHistoryPrintedBoxes.TabIndex = 0;
            // 
            // tlpHistoryBatchInformation
            // 
            tlpHistoryBatchInformation.BackColor = SystemColors.GradientInactiveCaption;
            tlpHistoryBatchInformation.ColumnCount = 2;
            tlpHistoryBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpHistoryBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpHistoryBatchInformation.Controls.Add(label1, 0, 1);
            tlpHistoryBatchInformation.Controls.Add(label2, 0, 0);
            tlpHistoryBatchInformation.Controls.Add(txtHistoryBatchId, 1, 1);
            tlpHistoryBatchInformation.Controls.Add(btnHistorySearch, 1, 2);
            tlpHistoryBatchInformation.Dock = DockStyle.Fill;
            tlpHistoryBatchInformation.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tlpHistoryBatchInformation.Location = new Point(2, 8);
            tlpHistoryBatchInformation.Margin = new Padding(2, 3, 2, 3);
            tlpHistoryBatchInformation.Name = "tlpHistoryBatchInformation";
            tlpHistoryBatchInformation.RowCount = 3;
            tlpHistoryBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpHistoryBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6176472F));
            tlpHistoryBatchInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpHistoryBatchInformation.Size = new Size(587, 136);
            tlpHistoryBatchInformation.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 53);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(228, 33);
            label1.TabIndex = 12;
            label1.Text = "Batch ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            tlpHistoryBatchInformation.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 3);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(581, 44);
            label2.TabIndex = 0;
            label2.Tag = "title left";
            label2.Text = "Batch Information";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHistoryBatchId
            // 
            txtHistoryBatchId.Dock = DockStyle.Fill;
            txtHistoryBatchId.Location = new Point(237, 53);
            txtHistoryBatchId.Margin = new Padding(3, 3, 10, 3);
            txtHistoryBatchId.Name = "txtHistoryBatchId";
            txtHistoryBatchId.Size = new Size(340, 26);
            txtHistoryBatchId.TabIndex = 14;
            // 
            // btnHistorySearch
            // 
            btnHistorySearch.Dock = DockStyle.Top;
            btnHistorySearch.Location = new Point(237, 92);
            btnHistorySearch.Margin = new Padding(3, 3, 10, 3);
            btnHistorySearch.Name = "btnHistorySearch";
            btnHistorySearch.Size = new Size(340, 41);
            btnHistorySearch.TabIndex = 15;
            btnHistorySearch.Text = "Search";
            btnHistorySearch.UseVisualStyleBackColor = true;
            // 
            // AOIUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcAOI);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AOIUC";
            Size = new Size(603, 757);
            tlpAOIBatchInfo.ResumeLayout(false);
            tlpAOIBatchInfo.PerformLayout();
            tbcAOI.ResumeLayout(false);
            tbpAOINewBox.ResumeLayout(false);
            tlpBatchInformation.ResumeLayout(false);
            tbpAOIBoxHistory.ResumeLayout(false);
            tableHistoryLayout.ResumeLayout(false);
            tlpHistoryPrintedBoxes.ResumeLayout(false);
            tlpHistoryPrintedBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryPrintedBoxes).EndInit();
            tlpHistoryBatchInformation.ResumeLayout(false);
            tlpHistoryBatchInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TableLayoutPanel tlpClearPrintAOI;
        private Button btnPrintAOI;
        private Button btnClearAOI;
        private TableLayoutPanel tlpPrinterSettingAOI;
        private Label lblPrinterSettingAOI;
        private Label lblStickerAOI;
        private ComboBox cboStickerPrinterAOI;
        private TableLayoutPanel tlpAOIBatchInfo;
        private Label lblBatchNumberAOI;
        private Label lblNewBatchInfoAOI;
        private TextBox txbNewBatchNoAOI;
        private Label lblArticalAOI;
        private TextBox txbNewArticalAO;
        private Label lblQtyAOI;
        private TextBox txbNewQtyAOI;
        private TabControl tbcAOI;
        private TabPage tbpAOINewBox;
        private TabPage tbpAOIBoxHistory;
        private TableLayoutPanel tlpHistoryBatchInformation;
        private Label label1;
        private Label label2;
        private TextBox txtHistoryBatchId;
        private TableLayoutPanel tlpHistoryPrintedBoxes;
        private DataGridView dgvHistoryPrintedBoxes;
        private Button button5;
        private Button btnHistoryExportData;
        private TableLayoutPanel tlpBatchInformation;
        private CommonUC.PrintCommandUC printCommanduc1;
        private PrinterPickerUC printerPicker;
        private TableLayoutPanel tableHistoryLayout;
        private Label lblHistoryPrintedBoxes;
        private Button btnHistorySearch;
    }
}
