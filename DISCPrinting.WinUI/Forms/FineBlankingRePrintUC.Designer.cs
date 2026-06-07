namespace DISCPrinting.WinUI.Forms
{
    partial class FineBlankingRePrintUC
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
            tlpFBNewBatchInfo = new TableLayoutPanel();
            txtBatchId = new TextBox();
            lblBatchId = new Label();
            txbMachine = new TextBox();
            label1 = new Label();
            txbArticalNumberCoil = new TextBox();
            txbCoilCharge = new TextBox();
            txbToolID = new TextBox();
            lblNewBatchInfo = new Label();
            lblNewMachine = new Label();
            lblNewToolID = new Label();
            lblNewArticalNoCoil = new Label();
            lblCoilCharge = new Label();
            multiSelectComboBox1 = new DISCPrinting.WinUI.Forms.CommonUC.MultiSelectComboBox();
            trackPicker = new TrackPickerUC();
            printerPicker = new PrinterPickerUC();
            batchPicker = new BatchPickerUC();
            printCommand = new DISCPrinting.WinUI.Forms.CommonUC.PrintCommandUC();
            tlpLayout.SuspendLayout();
            tlpFBNewBatchInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpLayout
            // 
            tlpLayout.ColumnCount = 3;
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tlpLayout.Controls.Add(tlpFBNewBatchInfo, 1, 1);
            tlpLayout.Controls.Add(printerPicker, 1, 5);
            tlpLayout.Controls.Add(batchPicker, 1, 3);
            tlpLayout.Controls.Add(printCommand, 1, 7);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Location = new Point(0, 0);
            tlpLayout.Margin = new Padding(3, 2, 3, 2);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 9;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.40613F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 95.59387F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpLayout.Size = new Size(691, 590);
            tlpLayout.TabIndex = 19;
            // 
            // tlpFBNewBatchInfo
            // 
            tlpFBNewBatchInfo.BackColor = SystemColors.GradientInactiveCaption;
            tlpFBNewBatchInfo.ColumnCount = 2;
            tlpFBNewBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4710732F));
            tlpFBNewBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.52892F));
            tlpFBNewBatchInfo.Controls.Add(txtBatchId, 1, 1);
            tlpFBNewBatchInfo.Controls.Add(lblBatchId, 0, 1);
            tlpFBNewBatchInfo.Controls.Add(txbMachine, 1, 2);
            tlpFBNewBatchInfo.Controls.Add(label1, 0, 6);
            tlpFBNewBatchInfo.Controls.Add(txbArticalNumberCoil, 1, 5);
            tlpFBNewBatchInfo.Controls.Add(txbCoilCharge, 1, 4);
            tlpFBNewBatchInfo.Controls.Add(txbToolID, 1, 3);
            tlpFBNewBatchInfo.Controls.Add(lblNewBatchInfo, 0, 0);
            tlpFBNewBatchInfo.Controls.Add(lblNewMachine, 0, 2);
            tlpFBNewBatchInfo.Controls.Add(lblNewToolID, 0, 3);
            tlpFBNewBatchInfo.Controls.Add(lblNewArticalNoCoil, 0, 5);
            tlpFBNewBatchInfo.Controls.Add(lblCoilCharge, 0, 4);
            tlpFBNewBatchInfo.Controls.Add(multiSelectComboBox1, 1, 6);
            tlpFBNewBatchInfo.Controls.Add(trackPicker, 0, 7);
            tlpFBNewBatchInfo.Dock = DockStyle.Fill;
            tlpFBNewBatchInfo.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlpFBNewBatchInfo.ForeColor = SystemColors.ControlText;
            tlpFBNewBatchInfo.Location = new Point(9, 17);
            tlpFBNewBatchInfo.Margin = new Padding(3, 2, 3, 2);
            tlpFBNewBatchInfo.Name = "tlpFBNewBatchInfo";
            tlpFBNewBatchInfo.RowCount = 8;
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFBNewBatchInfo.Size = new Size(671, 325);
            tlpFBNewBatchInfo.TabIndex = 13;
            // 
            // txtBatchId
            // 
            txtBatchId.Dock = DockStyle.Fill;
            txtBatchId.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBatchId.Location = new Point(227, 42);
            txtBatchId.Margin = new Padding(3, 2, 9, 2);
            txtBatchId.Name = "txtBatchId";
            txtBatchId.Size = new Size(435, 24);
            txtBatchId.TabIndex = 17;
            txtBatchId.KeyUp += txtBatchId_KeyUp;
            // 
            // lblBatchId
            // 
            lblBatchId.AutoSize = true;
            lblBatchId.Dock = DockStyle.Fill;
            lblBatchId.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBatchId.Location = new Point(3, 40);
            lblBatchId.Name = "lblBatchId";
            lblBatchId.Padding = new Padding(0, 5, 0, 0);
            lblBatchId.Size = new Size(218, 40);
            lblBatchId.TabIndex = 16;
            lblBatchId.Text = "Batch ID FB";
            // 
            // txbMachine
            // 
            txbMachine.Dock = DockStyle.Fill;
            txbMachine.Enabled = false;
            txbMachine.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbMachine.Location = new Point(227, 82);
            txbMachine.Margin = new Padding(3, 2, 9, 2);
            txbMachine.Name = "txbMachine";
            txbMachine.Size = new Size(435, 24);
            txbMachine.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 240);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 0);
            label1.Size = new Size(218, 40);
            label1.TabIndex = 14;
            label1.Text = "Paper type";
            // 
            // txbArticalNumberCoil
            // 
            txbArticalNumberCoil.Dock = DockStyle.Fill;
            txbArticalNumberCoil.Enabled = false;
            txbArticalNumberCoil.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbArticalNumberCoil.Location = new Point(227, 202);
            txbArticalNumberCoil.Margin = new Padding(3, 2, 9, 2);
            txbArticalNumberCoil.Name = "txbArticalNumberCoil";
            txbArticalNumberCoil.Size = new Size(435, 24);
            txbArticalNumberCoil.TabIndex = 11;
            // 
            // txbCoilCharge
            // 
            txbCoilCharge.Dock = DockStyle.Fill;
            txbCoilCharge.Enabled = false;
            txbCoilCharge.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCoilCharge.Location = new Point(227, 162);
            txbCoilCharge.Margin = new Padding(3, 2, 9, 2);
            txbCoilCharge.Name = "txbCoilCharge";
            txbCoilCharge.Size = new Size(435, 24);
            txbCoilCharge.TabIndex = 10;
            // 
            // txbToolID
            // 
            txbToolID.Dock = DockStyle.Fill;
            txbToolID.Enabled = false;
            txbToolID.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbToolID.Location = new Point(227, 122);
            txbToolID.Margin = new Padding(3, 2, 9, 2);
            txbToolID.Name = "txbToolID";
            txbToolID.Size = new Size(435, 24);
            txbToolID.TabIndex = 8;
            // 
            // lblNewBatchInfo
            // 
            lblNewBatchInfo.AutoSize = true;
            tlpFBNewBatchInfo.SetColumnSpan(lblNewBatchInfo, 2);
            lblNewBatchInfo.Dock = DockStyle.Fill;
            lblNewBatchInfo.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            lblNewBatchInfo.Location = new Point(3, 2);
            lblNewBatchInfo.Margin = new Padding(3, 2, 3, 2);
            lblNewBatchInfo.Name = "lblNewBatchInfo";
            lblNewBatchInfo.Size = new Size(665, 36);
            lblNewBatchInfo.TabIndex = 0;
            lblNewBatchInfo.Tag = "title left";
            lblNewBatchInfo.Text = "Batch Information";
            lblNewBatchInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNewMachine
            // 
            lblNewMachine.AutoSize = true;
            lblNewMachine.Dock = DockStyle.Fill;
            lblNewMachine.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewMachine.Location = new Point(3, 80);
            lblNewMachine.Name = "lblNewMachine";
            lblNewMachine.Padding = new Padding(0, 5, 0, 0);
            lblNewMachine.Size = new Size(218, 40);
            lblNewMachine.TabIndex = 1;
            lblNewMachine.Text = "Machine";
            // 
            // lblNewToolID
            // 
            lblNewToolID.AutoSize = true;
            lblNewToolID.Dock = DockStyle.Fill;
            lblNewToolID.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewToolID.Location = new Point(3, 120);
            lblNewToolID.Name = "lblNewToolID";
            lblNewToolID.Padding = new Padding(0, 5, 0, 0);
            lblNewToolID.Size = new Size(218, 40);
            lblNewToolID.TabIndex = 2;
            lblNewToolID.Text = "Tool ID (SmS)";
            // 
            // lblNewArticalNoCoil
            // 
            lblNewArticalNoCoil.AutoSize = true;
            lblNewArticalNoCoil.Dock = DockStyle.Fill;
            lblNewArticalNoCoil.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewArticalNoCoil.Location = new Point(3, 200);
            lblNewArticalNoCoil.Name = "lblNewArticalNoCoil";
            lblNewArticalNoCoil.Padding = new Padding(0, 5, 0, 0);
            lblNewArticalNoCoil.Size = new Size(218, 40);
            lblNewArticalNoCoil.TabIndex = 5;
            lblNewArticalNoCoil.Text = "Artical No. Coil";
            // 
            // lblCoilCharge
            // 
            lblCoilCharge.AutoSize = true;
            lblCoilCharge.Dock = DockStyle.Fill;
            lblCoilCharge.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoilCharge.Location = new Point(3, 160);
            lblCoilCharge.Name = "lblCoilCharge";
            lblCoilCharge.Padding = new Padding(0, 5, 0, 0);
            lblCoilCharge.Size = new Size(218, 40);
            lblCoilCharge.TabIndex = 4;
            lblCoilCharge.Text = "Coil Charge";
            // 
            // multiSelectComboBox1
            // 
            multiSelectComboBox1.Dock = DockStyle.Fill;
            multiSelectComboBox1.Location = new Point(228, 242);
            multiSelectComboBox1.Margin = new Padding(4, 2, 4, 2);
            multiSelectComboBox1.Name = "multiSelectComboBox1";
            multiSelectComboBox1.Size = new Size(439, 36);
            multiSelectComboBox1.TabIndex = 19;
            // 
            // trackPicker
            // 
            tlpFBNewBatchInfo.SetColumnSpan(trackPicker, 2);
            trackPicker.Dock = DockStyle.Fill;
            trackPicker.Location = new Point(44, 282);
            trackPicker.Margin = new Padding(44, 2, 44, 2);
            trackPicker.Name = "trackPicker";
            trackPicker.Size = new Size(583, 41);
            trackPicker.TabIndex = 20;
            // 
            // printerPicker
            // 
            printerPicker.BackColor = Color.LightSteelBlue;
            printerPicker.Dock = DockStyle.Fill;
            printerPicker.Location = new Point(9, 429);
            printerPicker.Margin = new Padding(3, 2, 3, 2);
            printerPicker.Name = "printerPicker";
            printerPicker.Size = new Size(671, 89);
            printerPicker.TabIndex = 17;
            // 
            // batchPicker
            // 
            batchPicker.BackColor = Color.LightSteelBlue;
            batchPicker.Dock = DockStyle.Fill;
            batchPicker.Location = new Point(9, 354);
            batchPicker.Margin = new Padding(3, 2, 3, 2);
            batchPicker.Name = "batchPicker";
            batchPicker.Size = new Size(671, 64);
            batchPicker.TabIndex = 18;
            // 
            // printCommand
            // 
            printCommand.Dock = DockStyle.Fill;
            printCommand.Location = new Point(6, 529);
            printCommand.Margin = new Padding(0, 2, 0, 2);
            printCommand.Name = "printCommand";
            printCommand.Size = new Size(677, 43);
            printCommand.TabIndex = 19;
            // 
            // FineBlankingRePrintUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpLayout);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FineBlankingRePrintUC";
            Size = new Size(691, 590);
            tlpLayout.ResumeLayout(false);
            tlpFBNewBatchInfo.ResumeLayout(false);
            tlpFBNewBatchInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private PrinterPickerUC printerPicker;
        private BatchPickerUC batchPicker;
        private TableLayoutPanel tlpFBNewBatchInfo;
        private TextBox txtBatchId;
        private Label lblBatchId;
        private TextBox txbMachine;
        private Label label1;
        private TextBox txbArticalNumberCoil;
        private TextBox txbCoilCharge;
        private TextBox txbToolID;
        private Label lblNewBatchInfo;
        private Label lblNewMachine;
        private Label lblNewToolID;
        private Label lblNewArticalNoCoil;
        private Label lblCoilCharge;
        private CommonUC.MultiSelectComboBox multiSelectComboBox1;
        private CommonUC.PrintCommandUC printCommand;
        private TrackPickerUC trackPicker;
    }
}
