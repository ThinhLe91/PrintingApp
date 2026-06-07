namespace DISCPrinting.WinUI.Forms
{
    partial class FineBlankingHistoryUC
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
            tlpBatchInformation = new TableLayoutPanel();
            lblBatchInformation = new Label();
            lblCombinedBatchId = new Label();
            button2 = new Button();
            txtBatchId = new TextBox();
            tlpCombinedBatches = new TableLayoutPanel();
            lblCombinedBatches = new Label();
            dgvCombinedBatches = new DataGridView();
            tlpSmallBatches = new TableLayoutPanel();
            lblSmallBatches = new Label();
            dgvSmallBatches = new DataGridView();
            btnExportData = new Button();
            tlpLayout.SuspendLayout();
            tlpBatchInformation.SuspendLayout();
            tlpCombinedBatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombinedBatches).BeginInit();
            tlpSmallBatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSmallBatches).BeginInit();
            SuspendLayout();
            // 
            // tlpLayout
            // 
            tlpLayout.ColumnCount = 3;
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.Controls.Add(tlpBatchInformation, 1, 1);
            tlpLayout.Controls.Add(tlpCombinedBatches, 1, 3);
            tlpLayout.Controls.Add(tlpSmallBatches, 1, 5);
            tlpLayout.Controls.Add(btnExportData, 1, 6);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Location = new Point(0, 0);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 8;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 0.963799834F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4666662F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 3.6F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.6666679F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 1.703998F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8.4F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 0.9830758F));
            tlpLayout.Size = new Size(780, 750);
            tlpLayout.TabIndex = 0;
            // 
            // tlpBatchInformation
            // 
            tlpBatchInformation.BackColor = SystemColors.GradientInactiveCaption;
            tlpBatchInformation.ColumnCount = 2;
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBatchInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBatchInformation.Controls.Add(lblBatchInformation, 0, 0);
            tlpBatchInformation.Controls.Add(lblCombinedBatchId, 0, 1);
            tlpBatchInformation.Controls.Add(button2, 1, 2);
            tlpBatchInformation.Controls.Add(txtBatchId, 1, 1);
            tlpBatchInformation.Dock = DockStyle.Fill;
            tlpBatchInformation.Location = new Point(10, 10);
            tlpBatchInformation.Name = "tlpBatchInformation";
            tlpBatchInformation.RowCount = 3;
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 50.81967F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 49.18033F));
            tlpBatchInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpBatchInformation.Size = new Size(758, 110);
            tlpBatchInformation.TabIndex = 0;
            // 
            // lblBatchInformation
            // 
            lblBatchInformation.AutoSize = true;
            tlpBatchInformation.SetColumnSpan(lblBatchInformation, 2);
            lblBatchInformation.Dock = DockStyle.Fill;
            lblBatchInformation.Font = new Font("Bosch Office Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchInformation.Location = new Point(3, 3);
            lblBatchInformation.Margin = new Padding(3);
            lblBatchInformation.Name = "lblBatchInformation";
            lblBatchInformation.Size = new Size(752, 29);
            lblBatchInformation.TabIndex = 0;
            lblBatchInformation.Tag = "title left";
            lblBatchInformation.Text = "Batch Information";
            lblBatchInformation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCombinedBatchId
            // 
            lblCombinedBatchId.AutoSize = true;
            lblCombinedBatchId.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCombinedBatchId.Location = new Point(3, 35);
            lblCombinedBatchId.Name = "lblCombinedBatchId";
            lblCombinedBatchId.Padding = new Padding(0, 7, 0, 0);
            lblCombinedBatchId.Size = new Size(136, 24);
            lblCombinedBatchId.TabIndex = 0;
            lblCombinedBatchId.Text = "Combined Batch ID";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Bosch Office Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(382, 71);
            button2.Name = "button2";
            button2.Size = new Size(373, 36);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtBatchId
            // 
            txtBatchId.Dock = DockStyle.Fill;
            txtBatchId.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchId.Location = new Point(382, 38);
            txtBatchId.Name = "txtBatchId";
            txtBatchId.Size = new Size(373, 25);
            txtBatchId.TabIndex = 4;
            // 
            // tlpCombinedBatches
            // 
            tlpCombinedBatches.BackColor = SystemColors.GradientInactiveCaption;
            tlpCombinedBatches.ColumnCount = 1;
            tlpCombinedBatches.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCombinedBatches.Controls.Add(lblCombinedBatches, 0, 0);
            tlpCombinedBatches.Controls.Add(dgvCombinedBatches, 0, 1);
            tlpCombinedBatches.Dock = DockStyle.Fill;
            tlpCombinedBatches.Location = new Point(10, 153);
            tlpCombinedBatches.Name = "tlpCombinedBatches";
            tlpCombinedBatches.RowCount = 2;
            tlpCombinedBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0155039F));
            tlpCombinedBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 87.9845F));
            tlpCombinedBatches.Size = new Size(758, 284);
            tlpCombinedBatches.TabIndex = 1;
            // 
            // lblCombinedBatches
            // 
            lblCombinedBatches.AutoSize = true;
            lblCombinedBatches.Dock = DockStyle.Fill;
            lblCombinedBatches.Font = new Font("Bosch Office Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCombinedBatches.Location = new Point(3, 3);
            lblCombinedBatches.Margin = new Padding(3);
            lblCombinedBatches.Name = "lblCombinedBatches";
            lblCombinedBatches.Size = new Size(752, 28);
            lblCombinedBatches.TabIndex = 0;
            lblCombinedBatches.Tag = "title left";
            lblCombinedBatches.Text = "Combined Batches";
            lblCombinedBatches.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvCombinedBatches
            // 
            dgvCombinedBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombinedBatches.Dock = DockStyle.Fill;
            dgvCombinedBatches.Location = new Point(3, 37);
            dgvCombinedBatches.Name = "dgvCombinedBatches";
            dgvCombinedBatches.RowHeadersWidth = 51;
            dgvCombinedBatches.Size = new Size(752, 244);
            dgvCombinedBatches.TabIndex = 1;
            // 
            // tlpSmallBatches
            // 
            tlpSmallBatches.BackColor = SystemColors.GradientInactiveCaption;
            tlpSmallBatches.ColumnCount = 1;
            tlpSmallBatches.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSmallBatches.Controls.Add(lblSmallBatches, 0, 0);
            tlpSmallBatches.Controls.Add(dgvSmallBatches, 0, 1);
            tlpSmallBatches.Dock = DockStyle.Fill;
            tlpSmallBatches.Location = new Point(10, 455);
            tlpSmallBatches.Name = "tlpSmallBatches";
            tlpSmallBatches.RowCount = 2;
            tlpSmallBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9817352F));
            tlpSmallBatches.RowStyles.Add(new RowStyle(SizeType.Percent, 84.0182648F));
            tlpSmallBatches.Size = new Size(758, 219);
            tlpSmallBatches.TabIndex = 2;
            // 
            // lblSmallBatches
            // 
            lblSmallBatches.AutoSize = true;
            lblSmallBatches.Dock = DockStyle.Fill;
            lblSmallBatches.Font = new Font("Bosch Office Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSmallBatches.Location = new Point(3, 3);
            lblSmallBatches.Margin = new Padding(3);
            lblSmallBatches.Name = "lblSmallBatches";
            lblSmallBatches.Size = new Size(752, 29);
            lblSmallBatches.TabIndex = 0;
            lblSmallBatches.Tag = "title left";
            lblSmallBatches.Text = "Small Batches";
            lblSmallBatches.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvSmallBatches
            // 
            dgvSmallBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSmallBatches.Dock = DockStyle.Fill;
            dgvSmallBatches.Location = new Point(3, 38);
            dgvSmallBatches.Name = "dgvSmallBatches";
            dgvSmallBatches.RowHeadersWidth = 51;
            dgvSmallBatches.Size = new Size(752, 178);
            dgvSmallBatches.TabIndex = 1;
            // 
            // btnExportData
            // 
            btnExportData.Dock = DockStyle.Fill;
            btnExportData.Font = new Font("Bosch Office Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportData.Location = new Point(10, 687);
            btnExportData.Margin = new Padding(3, 10, 3, 3);
            btnExportData.Name = "btnExportData";
            btnExportData.Size = new Size(758, 50);
            btnExportData.TabIndex = 3;
            btnExportData.Text = "Export Data";
            btnExportData.UseVisualStyleBackColor = true;
            // 
            // FineBlankingHistoryUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpLayout);
            Name = "FineBlankingHistoryUC";
            Size = new Size(780, 750);
            tlpLayout.ResumeLayout(false);
            tlpBatchInformation.ResumeLayout(false);
            tlpBatchInformation.PerformLayout();
            tlpCombinedBatches.ResumeLayout(false);
            tlpCombinedBatches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombinedBatches).EndInit();
            tlpSmallBatches.ResumeLayout(false);
            tlpSmallBatches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSmallBatches).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private TableLayoutPanel tlpBatchInformation;
        private TableLayoutPanel tlpCombinedBatches;
        private Label lblBatchInformation;
        private Label lblCombinedBatchId;
        private Label lblCombinedBatches;
        private TableLayoutPanel tlpSmallBatches;
        private Label lblSmallBatches;
        private Button btnExportData;
        private Button button2;
        private TextBox txtBatchId;
        private DataGridView dgvCombinedBatches;
        private DataGridView dgvSmallBatches;
    }
}
