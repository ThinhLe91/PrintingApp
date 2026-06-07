namespace DISCPrinting.WinUI.Forms
{
    partial class BatchPickerUC
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ckbBatch5 = new CheckBox();
            ckbBatch4 = new CheckBox();
            ckbBatch3 = new CheckBox();
            ckbBatch2 = new CheckBox();
            ckbBatch1 = new CheckBox();
            ckbBatchAll = new CheckBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(ckbBatch5, 5, 1);
            tableLayoutPanel1.Controls.Add(ckbBatch4, 4, 1);
            tableLayoutPanel1.Controls.Add(ckbBatch3, 3, 1);
            tableLayoutPanel1.Controls.Add(ckbBatch2, 2, 1);
            tableLayoutPanel1.Controls.Add(ckbBatch1, 1, 1);
            tableLayoutPanel1.Controls.Add(ckbBatchAll, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(728, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ckbBatch5
            // 
            ckbBatch5.AutoSize = true;
            ckbBatch5.Dock = DockStyle.Fill;
            ckbBatch5.Font = new Font("Bosch Office Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBatch5.Location = new Point(596, 93);
            ckbBatch5.Name = "ckbBatch5";
            ckbBatch5.Size = new Size(129, 54);
            ckbBatch5.TabIndex = 6;
            ckbBatch5.Tag = "center";
            ckbBatch5.Text = "Batch 5";
            ckbBatch5.UseVisualStyleBackColor = true;
            ckbBatch5.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbBatch4
            // 
            ckbBatch4.AutoSize = true;
            ckbBatch4.Dock = DockStyle.Fill;
            ckbBatch4.Font = new Font("Bosch Office Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBatch4.Location = new Point(463, 93);
            ckbBatch4.Name = "ckbBatch4";
            ckbBatch4.Size = new Size(127, 54);
            ckbBatch4.TabIndex = 5;
            ckbBatch4.Tag = "center";
            ckbBatch4.Text = "Batch 4";
            ckbBatch4.UseVisualStyleBackColor = true;
            ckbBatch4.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbBatch3
            // 
            ckbBatch3.AutoSize = true;
            ckbBatch3.Dock = DockStyle.Fill;
            ckbBatch3.Font = new Font("Bosch Office Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBatch3.Location = new Point(330, 93);
            ckbBatch3.Name = "ckbBatch3";
            ckbBatch3.Size = new Size(127, 54);
            ckbBatch3.TabIndex = 4;
            ckbBatch3.Tag = "center";
            ckbBatch3.Text = "Batch 3";
            ckbBatch3.UseVisualStyleBackColor = true;
            ckbBatch3.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbBatch2
            // 
            ckbBatch2.AutoSize = true;
            ckbBatch2.Dock = DockStyle.Fill;
            ckbBatch2.Font = new Font("Bosch Office Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBatch2.Location = new Point(197, 93);
            ckbBatch2.Name = "ckbBatch2";
            ckbBatch2.Size = new Size(127, 54);
            ckbBatch2.TabIndex = 3;
            ckbBatch2.Tag = "center";
            ckbBatch2.Text = "Batch 2";
            ckbBatch2.UseVisualStyleBackColor = true;
            ckbBatch2.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbBatch1
            // 
            ckbBatch1.AutoSize = true;
            ckbBatch1.Dock = DockStyle.Fill;
            ckbBatch1.Font = new Font("Bosch Office Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBatch1.Location = new Point(64, 93);
            ckbBatch1.Name = "ckbBatch1";
            ckbBatch1.Size = new Size(127, 54);
            ckbBatch1.TabIndex = 2;
            ckbBatch1.Tag = "center";
            ckbBatch1.Text = "Batch 1";
            ckbBatch1.UseVisualStyleBackColor = true;
            ckbBatch1.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbBatchAll
            // 
            ckbBatchAll.AutoSize = true;
            ckbBatchAll.Dock = DockStyle.Fill;
            ckbBatchAll.Font = new Font("Bosch Office Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBatchAll.Location = new Point(3, 93);
            ckbBatchAll.Name = "ckbBatchAll";
            ckbBatchAll.Padding = new Padding(5, 0, 0, 0);
            ckbBatchAll.Size = new Size(55, 54);
            ckbBatchAll.TabIndex = 1;
            ckbBatchAll.Tag = "center";
            ckbBatchAll.Text = "All";
            ckbBatchAll.UseVisualStyleBackColor = true;
            ckbBatchAll.CheckedChanged += CheckedChangeHandle;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.SetColumnSpan(label1, 6);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(722, 84);
            label1.TabIndex = 0;
            label1.Tag = "title left";
            label1.Text = "Print Option";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BatchPickerUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(tableLayoutPanel1);
            Name = "BatchPickerUC";
            Size = new Size(728, 150);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox ckbBatchAll;
        private CheckBox checkBox6;
        private Label label1;
        private CheckBox ckbBatch5;
        private CheckBox ckbBatch4;
        private CheckBox ckbBatch3;
        private CheckBox ckbBatch2;
        private CheckBox ckbBatch1;
    }
}
