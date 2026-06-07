namespace DISCPrinting.WinUI.Forms
{
    partial class FineBlankingCombineUC
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
            lblCombineBatchID = new Label();
            tlpBatchInformation = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            btnCombine = new Button();
            txtBatchId = new TextBox();
            txtQuantity = new NumericUpDown();
            tlpCombinedBatches = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            printerPickeruc1 = new PrinterPickerUC();
            printCommand = new DISCPrinting.WinUI.Forms.CommonUC.PrintCommandUC();
            tlpLayout.SuspendLayout();
            tlpBatchInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            tlpCombinedBatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tlpLayout
            // 
            tlpLayout.ColumnCount = 3;
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.Controls.Add(lblCombineBatchID, 1, 2);
            tlpLayout.Controls.Add(tlpBatchInformation, 1, 1);
            tlpLayout.Controls.Add(tlpCombinedBatches, 1, 3);
            tlpLayout.Controls.Add(printerPickeruc1, 1, 5);
            tlpLayout.Controls.Add(printCommand, 1, 6);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Location = new Point(0, 0);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 8;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 1.00118911F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45.5772133F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.19790125F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0124F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 1.50103331F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1518288F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.498062F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 1.00118911F));
            tlpLayout.Size = new Size(900, 667);
            tlpLayout.TabIndex = 0;
            // 
            // lblCombineBatchID
            // 
            lblCombineBatchID.AutoSize = true;
            lblCombineBatchID.Dock = DockStyle.Fill;
            lblCombineBatchID.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCombineBatchID.ForeColor = SystemColors.Highlight;
            lblCombineBatchID.Location = new Point(12, 313);
            lblCombineBatchID.Margin = new Padding(3);
            lblCombineBatchID.Name = "lblCombineBatchID";
            lblCombineBatchID.Size = new Size(876, 22);
            lblCombineBatchID.TabIndex = 17;
            lblCombineBatchID.Tag = "title center";
            lblCombineBatchID.Text = "Combine: \"Batch ID\"";
            lblCombineBatchID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBatchInformation
            // 
            tlpBatchInformation.BackColor = SystemColors.GradientInactiveCaption;
            tlpBatchInformation.ColumnCount = 3;
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.94977F));
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.83105F));
            tlpBatchInformation.Controls.Add(label4, 0, 4);
            tlpBatchInformation.Controls.Add(label3, 0, 2);
            tlpBatchInformation.Controls.Add(label2, 0, 1);
            tlpBatchInformation.Controls.Add(label1, 0, 0);
            tlpBatchInformation.Controls.Add(btnAdd, 2, 3);
            tlpBatchInformation.Controls.Add(dataGridView1, 0, 5);
            tlpBatchInformation.Controls.Add(btnCombine, 2, 5);
            tlpBatchInformation.Controls.Add(txtBatchId, 1, 1);
            tlpBatchInformation.Controls.Add(txtQuantity, 1, 2);
            tlpBatchInformation.Dock = DockStyle.Fill;
            tlpBatchInformation.Location = new Point(12, 9);
            tlpBatchInformation.Name = "tlpBatchInformation";
            tlpBatchInformation.RowCount = 6;
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 13.49481F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 11.418685F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 14.09396F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 9.395973F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 39.4463654F));
            tlpBatchInformation.Size = new Size(876, 298);
            tlpBatchInformation.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tlpBatchInformation.SetColumnSpan(label4, 3);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 154);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(870, 22);
            label4.TabIndex = 4;
            label4.Tag = "title left";
            label4.Text = "Small Batches";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 7, 0, 0);
            label3.Size = new Size(285, 34);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 7, 0, 0);
            label2.Size = new Size(285, 40);
            label2.TabIndex = 1;
            label2.Text = "Small Batch ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            tlpBatchInformation.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(870, 29);
            label1.TabIndex = 0;
            label1.Tag = "title left";
            label1.Text = "Batch Information";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(678, 112);
            btnAdd.Margin = new Padding(3, 3, 10, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 36);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpBatchInformation.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(669, 113);
            dataGridView1.TabIndex = 5;
            // 
            // btnCombine
            // 
            btnCombine.Dock = DockStyle.Top;
            btnCombine.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCombine.Location = new Point(678, 182);
            btnCombine.Margin = new Padding(3, 3, 10, 3);
            btnCombine.Name = "btnCombine";
            btnCombine.Size = new Size(188, 43);
            btnCombine.TabIndex = 3;
            btnCombine.Text = "Combine";
            btnCombine.UseVisualStyleBackColor = true;
            // 
            // txtBatchId
            // 
            tlpBatchInformation.SetColumnSpan(txtBatchId, 2);
            txtBatchId.Dock = DockStyle.Fill;
            txtBatchId.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchId.Location = new Point(294, 38);
            txtBatchId.Margin = new Padding(3, 3, 10, 3);
            txtBatchId.Name = "txtBatchId";
            txtBatchId.Size = new Size(572, 28);
            txtBatchId.TabIndex = 6;
            // 
            // txtQuantity
            // 
            tlpBatchInformation.SetColumnSpan(txtQuantity, 2);
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(294, 78);
            txtQuantity.Margin = new Padding(3, 3, 10, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(572, 28);
            txtQuantity.TabIndex = 7;
            // 
            // tlpCombinedBatches
            // 
            tlpCombinedBatches.BackColor = SystemColors.GradientInactiveCaption;
            tlpCombinedBatches.ColumnCount = 1;
            tlpCombinedBatches.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCombinedBatches.Controls.Add(dataGridView2, 0, 1);
            tlpCombinedBatches.Controls.Add(label5, 0, 0);
            tlpCombinedBatches.Dock = DockStyle.Fill;
            tlpCombinedBatches.Location = new Point(12, 341);
            tlpCombinedBatches.Name = "tlpCombinedBatches";
            tlpCombinedBatches.RowCount = 2;
            tlpCombinedBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tlpCombinedBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 73.68421F));
            tlpCombinedBatches.Size = new Size(876, 114);
            tlpCombinedBatches.TabIndex = 18;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpCombinedBatches.SetColumnSpan(dataGridView2, 2);
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 33);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(870, 78);
            dataGridView2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tlpCombinedBatches.SetColumnSpan(label5, 3);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 3);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(870, 24);
            label5.TabIndex = 1;
            label5.Tag = "title left";
            label5.Text = "Combined Batches";
            // 
            // printerPickeruc1
            // 
            printerPickeruc1.BackColor = Color.LightSteelBlue;
            printerPickeruc1.Dock = DockStyle.Fill;
            printerPickeruc1.Location = new Point(12, 471);
            printerPickeruc1.Name = "printerPickeruc1";
            printerPickeruc1.Size = new Size(876, 121);
            printerPickeruc1.TabIndex = 19;
            // 
            // printCommand
            // 
            printCommand.Dock = DockStyle.Fill;
            printCommand.Location = new Point(12, 598);
            printCommand.Name = "printCommand";
            printCommand.Size = new Size(876, 57);
            printCommand.TabIndex = 20;
            // 
            // FineBlankingCombineUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpLayout);
            Name = "FineBlankingCombineUC";
            Size = new Size(900, 667);
            tlpLayout.ResumeLayout(false);
            tlpLayout.PerformLayout();
            tlpBatchInformation.ResumeLayout(false);
            tlpBatchInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            tlpCombinedBatches.ResumeLayout(false);
            tlpCombinedBatches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private TableLayoutPanel tlpBatchInformation;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnCombine;
        private TextBox txtBatchId;
        private NumericUpDown txtQuantity;
        private Label lblCombineBatchID;
        private TableLayoutPanel tlpCombinedBatches;
        private DataGridView dataGridView2;
        private Label label5;
        private PrinterPickerUC printerPickeruc1;
        private CommonUC.PrintCommandUC printCommand;
    }
}
