namespace DISCPrinting.WinUI.Forms
{
    partial class FineBlankingNewUC
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
            txbNewArticalNoCoil = new TextBox();
            txbNewCoilCharge = new TextBox();
            txbNewToolID = new TextBox();
            lblNewBatchInfo = new Label();
            lblNewMachine = new Label();
            lblNewToolID = new Label();
            lblNewArticalNoCoil = new Label();
            cboNewMachine = new ComboBox();
            lblNewArticalNoDeburr = new Label();
            txbNewArticalNoFB = new TextBox();
            lblNewArticalNoFB = new Label();
            lblCoilCharge = new Label();
            txbNewArticalNoDeburr = new TextBox();
            lblPrintingBatchID = new Label();
            printerPickeruc1 = new PrinterPickerUC();
            batchPickeruc1 = new BatchPickerUC();
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
            tlpLayout.Controls.Add(lblPrintingBatchID, 1, 2);
            tlpLayout.Controls.Add(printerPickeruc1, 1, 5);
            tlpLayout.Controls.Add(batchPickeruc1, 1, 3);
            tlpLayout.Controls.Add(printCommand, 1, 7);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Location = new Point(0, 0);
            tlpLayout.Margin = new Padding(3, 2, 3, 2);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 9;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.40613F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 95.59387F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpLayout.Size = new Size(550, 550);
            tlpLayout.TabIndex = 18;
            // 
            // tlpFBNewBatchInfo
            // 
            tlpFBNewBatchInfo.BackColor = SystemColors.GradientInactiveCaption;
            tlpFBNewBatchInfo.ColumnCount = 2;
            tlpFBNewBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4710732F));
            tlpFBNewBatchInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.52892F));
            tlpFBNewBatchInfo.Controls.Add(txbNewArticalNoCoil, 1, 5);
            tlpFBNewBatchInfo.Controls.Add(txbNewCoilCharge, 1, 3);
            tlpFBNewBatchInfo.Controls.Add(txbNewToolID, 1, 2);
            tlpFBNewBatchInfo.Controls.Add(lblNewBatchInfo, 0, 0);
            tlpFBNewBatchInfo.Controls.Add(lblNewMachine, 0, 1);
            tlpFBNewBatchInfo.Controls.Add(lblNewToolID, 0, 2);
            tlpFBNewBatchInfo.Controls.Add(lblNewArticalNoCoil, 0, 5);
            tlpFBNewBatchInfo.Controls.Add(cboNewMachine, 1, 1);
            tlpFBNewBatchInfo.Controls.Add(lblNewArticalNoDeburr, 0, 6);
            tlpFBNewBatchInfo.Controls.Add(txbNewArticalNoFB, 1, 4);
            tlpFBNewBatchInfo.Controls.Add(lblNewArticalNoFB, 0, 4);
            tlpFBNewBatchInfo.Controls.Add(lblCoilCharge, 0, 3);
            tlpFBNewBatchInfo.Controls.Add(txbNewArticalNoDeburr, 1, 6);
            tlpFBNewBatchInfo.Dock = DockStyle.Fill;
            tlpFBNewBatchInfo.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlpFBNewBatchInfo.ForeColor = SystemColors.ControlText;
            tlpFBNewBatchInfo.Location = new Point(8, 13);
            tlpFBNewBatchInfo.Margin = new Padding(3, 2, 3, 2);
            tlpFBNewBatchInfo.Name = "tlpFBNewBatchInfo";
            tlpFBNewBatchInfo.RowCount = 7;
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853079F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853041F));
            tlpFBNewBatchInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881622F));
            tlpFBNewBatchInfo.Size = new Size(533, 246);
            tlpFBNewBatchInfo.TabIndex = 13;
            // 
            // txbNewArticalNoCoil
            // 
            txbNewArticalNoCoil.Dock = DockStyle.Fill;
            txbNewArticalNoCoil.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNewArticalNoCoil.Location = new Point(181, 177);
            txbNewArticalNoCoil.Margin = new Padding(3, 2, 9, 2);
            txbNewArticalNoCoil.Name = "txbNewArticalNoCoil";
            txbNewArticalNoCoil.Size = new Size(343, 24);
            txbNewArticalNoCoil.TabIndex = 11;
            // 
            // txbNewCoilCharge
            // 
            txbNewCoilCharge.Dock = DockStyle.Fill;
            txbNewCoilCharge.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNewCoilCharge.Location = new Point(181, 107);
            txbNewCoilCharge.Margin = new Padding(3, 2, 9, 2);
            txbNewCoilCharge.Name = "txbNewCoilCharge";
            txbNewCoilCharge.Size = new Size(343, 24);
            txbNewCoilCharge.TabIndex = 10;
            // 
            // txbNewToolID
            // 
            txbNewToolID.Dock = DockStyle.Fill;
            txbNewToolID.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNewToolID.Location = new Point(181, 72);
            txbNewToolID.Margin = new Padding(3, 2, 9, 2);
            txbNewToolID.Name = "txbNewToolID";
            txbNewToolID.Size = new Size(343, 24);
            txbNewToolID.TabIndex = 8;
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
            lblNewBatchInfo.Size = new Size(527, 31);
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
            lblNewMachine.Location = new Point(3, 35);
            lblNewMachine.Name = "lblNewMachine";
            lblNewMachine.Padding = new Padding(0, 5, 0, 0);
            lblNewMachine.Size = new Size(172, 35);
            lblNewMachine.TabIndex = 1;
            lblNewMachine.Text = "Machine";
            // 
            // lblNewToolID
            // 
            lblNewToolID.AutoSize = true;
            lblNewToolID.Dock = DockStyle.Fill;
            lblNewToolID.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewToolID.Location = new Point(3, 70);
            lblNewToolID.Name = "lblNewToolID";
            lblNewToolID.Padding = new Padding(0, 5, 0, 0);
            lblNewToolID.Size = new Size(172, 35);
            lblNewToolID.TabIndex = 2;
            lblNewToolID.Text = "Tool ID (SmS)";
            // 
            // lblNewArticalNoCoil
            // 
            lblNewArticalNoCoil.AutoSize = true;
            lblNewArticalNoCoil.Dock = DockStyle.Fill;
            lblNewArticalNoCoil.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewArticalNoCoil.Location = new Point(3, 175);
            lblNewArticalNoCoil.Name = "lblNewArticalNoCoil";
            lblNewArticalNoCoil.Padding = new Padding(0, 5, 0, 0);
            lblNewArticalNoCoil.Size = new Size(172, 35);
            lblNewArticalNoCoil.TabIndex = 5;
            lblNewArticalNoCoil.Text = "Artical No. Coil";
            // 
            // cboNewMachine
            // 
            cboNewMachine.Dock = DockStyle.Fill;
            cboNewMachine.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboNewMachine.FormattingEnabled = true;
            cboNewMachine.Location = new Point(181, 37);
            cboNewMachine.Margin = new Padding(3, 2, 9, 2);
            cboNewMachine.Name = "cboNewMachine";
            cboNewMachine.Size = new Size(343, 24);
            cboNewMachine.TabIndex = 6;
            // 
            // lblNewArticalNoDeburr
            // 
            lblNewArticalNoDeburr.AutoSize = true;
            lblNewArticalNoDeburr.Dock = DockStyle.Fill;
            lblNewArticalNoDeburr.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewArticalNoDeburr.Location = new Point(3, 210);
            lblNewArticalNoDeburr.Name = "lblNewArticalNoDeburr";
            lblNewArticalNoDeburr.Padding = new Padding(0, 5, 0, 0);
            lblNewArticalNoDeburr.Size = new Size(172, 36);
            lblNewArticalNoDeburr.TabIndex = 12;
            lblNewArticalNoDeburr.Text = "Artical No. Deburring";
            // 
            // txbNewArticalNoFB
            // 
            txbNewArticalNoFB.Dock = DockStyle.Fill;
            txbNewArticalNoFB.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNewArticalNoFB.Location = new Point(181, 142);
            txbNewArticalNoFB.Margin = new Padding(3, 2, 9, 2);
            txbNewArticalNoFB.Name = "txbNewArticalNoFB";
            txbNewArticalNoFB.Size = new Size(343, 24);
            txbNewArticalNoFB.TabIndex = 9;
            // 
            // lblNewArticalNoFB
            // 
            lblNewArticalNoFB.AutoSize = true;
            lblNewArticalNoFB.Dock = DockStyle.Fill;
            lblNewArticalNoFB.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewArticalNoFB.Location = new Point(3, 140);
            lblNewArticalNoFB.Name = "lblNewArticalNoFB";
            lblNewArticalNoFB.Padding = new Padding(0, 5, 0, 0);
            lblNewArticalNoFB.Size = new Size(172, 35);
            lblNewArticalNoFB.TabIndex = 3;
            lblNewArticalNoFB.Text = "Artical No. FB";
            // 
            // lblCoilCharge
            // 
            lblCoilCharge.AutoSize = true;
            lblCoilCharge.Dock = DockStyle.Fill;
            lblCoilCharge.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoilCharge.Location = new Point(3, 105);
            lblCoilCharge.Name = "lblCoilCharge";
            lblCoilCharge.Padding = new Padding(0, 5, 0, 0);
            lblCoilCharge.Size = new Size(172, 35);
            lblCoilCharge.TabIndex = 4;
            lblCoilCharge.Text = "Coil Charge";
            // 
            // txbNewArticalNoDeburr
            // 
            txbNewArticalNoDeburr.Dock = DockStyle.Fill;
            txbNewArticalNoDeburr.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNewArticalNoDeburr.Location = new Point(181, 212);
            txbNewArticalNoDeburr.Margin = new Padding(3, 2, 9, 2);
            txbNewArticalNoDeburr.Name = "txbNewArticalNoDeburr";
            txbNewArticalNoDeburr.Size = new Size(343, 24);
            txbNewArticalNoDeburr.TabIndex = 13;
            // 
            // lblPrintingBatchID
            // 
            lblPrintingBatchID.AutoSize = true;
            lblPrintingBatchID.Dock = DockStyle.Fill;
            lblPrintingBatchID.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrintingBatchID.ForeColor = SystemColors.Highlight;
            lblPrintingBatchID.Location = new Point(8, 263);
            lblPrintingBatchID.Margin = new Padding(3, 2, 3, 2);
            lblPrintingBatchID.Name = "lblPrintingBatchID";
            lblPrintingBatchID.Size = new Size(533, 29);
            lblPrintingBatchID.TabIndex = 16;
            lblPrintingBatchID.Text = "Printing: \"Batch ID\"";
            lblPrintingBatchID.TextAlign = ContentAlignment.MiddleCenter;
            lblPrintingBatchID.Visible = false;
            // 
            // printerPickeruc1
            // 
            printerPickeruc1.BackColor = Color.LightSteelBlue;
            printerPickeruc1.Dock = DockStyle.Fill;
            printerPickeruc1.Location = new Point(8, 389);
            printerPickeruc1.Margin = new Padding(3, 2, 3, 2);
            printerPickeruc1.Name = "printerPickeruc1";
            printerPickeruc1.Size = new Size(533, 89);
            printerPickeruc1.TabIndex = 17;
            // 
            // batchPickeruc1
            // 
            batchPickeruc1.BackColor = Color.LightSteelBlue;
            batchPickeruc1.Dock = DockStyle.Fill;
            batchPickeruc1.Location = new Point(8, 296);
            batchPickeruc1.Margin = new Padding(3, 2, 3, 2);
            batchPickeruc1.Name = "batchPickeruc1";
            batchPickeruc1.Size = new Size(533, 66);
            batchPickeruc1.TabIndex = 18;
            // 
            // printCommand
            // 
            printCommand.Dock = DockStyle.Fill;
            printCommand.Location = new Point(8, 489);
            printCommand.Margin = new Padding(3, 2, 3, 2);
            printCommand.Name = "printCommand";
            printCommand.Size = new Size(533, 43);
            printCommand.TabIndex = 19;
            // 
            // FineBlankingNewUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpLayout);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FineBlankingNewUC";
            Size = new Size(550, 550);
            tlpLayout.ResumeLayout(false);
            tlpLayout.PerformLayout();
            tlpFBNewBatchInfo.ResumeLayout(false);
            tlpFBNewBatchInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private TableLayoutPanel tlpFBNewBatchInfo;
        private TextBox txbNewArticalNoCoil;
        private TextBox txbNewCoilCharge;
        private TextBox txbNewToolID;
        private Label lblNewBatchInfo;
        private Label lblNewMachine;
        private Label lblNewToolID;
        private Label lblNewArticalNoCoil;
        private ComboBox cboNewMachine;
        private Label lblNewArticalNoDeburr;
        private TextBox txbNewArticalNoFB;
        private Label lblNewArticalNoFB;
        private Label lblCoilCharge;
        private TextBox txbNewArticalNoDeburr;
        private Label lblPrintingBatchID;
        private PrinterPickerUC printerPickeruc1;
        private BatchPickerUC batchPickeruc1;
        private CommonUC.PrintCommandUC printCommand;
    }
}
