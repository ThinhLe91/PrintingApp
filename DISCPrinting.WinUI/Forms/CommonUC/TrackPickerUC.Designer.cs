namespace DISCPrinting.WinUI.Forms
{
    partial class TrackPickerUC
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
            ckbTrack4 = new CheckBox();
            ckbTrack3 = new CheckBox();
            ckbTrack2 = new CheckBox();
            ckbTrack1 = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(ckbTrack4, 3, 0);
            tableLayoutPanel1.Controls.Add(ckbTrack3, 2, 0);
            tableLayoutPanel1.Controls.Add(ckbTrack2, 1, 0);
            tableLayoutPanel1.Controls.Add(ckbTrack1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(500, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ckbTrack4
            // 
            ckbTrack4.AutoSize = true;
            ckbTrack4.Dock = DockStyle.Fill;
            ckbTrack4.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbTrack4.Location = new Point(378, 3);
            ckbTrack4.Name = "ckbTrack4";
            ckbTrack4.Size = new Size(119, 94);
            ckbTrack4.TabIndex = 3;
            ckbTrack4.Tag = "center";
            ckbTrack4.Text = "Track 4";
            ckbTrack4.UseVisualStyleBackColor = true;
            ckbTrack4.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbTrack3
            // 
            ckbTrack3.AutoSize = true;
            ckbTrack3.Dock = DockStyle.Fill;
            ckbTrack3.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbTrack3.Location = new Point(253, 3);
            ckbTrack3.Name = "ckbTrack3";
            ckbTrack3.Size = new Size(119, 94);
            ckbTrack3.TabIndex = 2;
            ckbTrack3.Tag = "center";
            ckbTrack3.Text = "Track 3";
            ckbTrack3.UseVisualStyleBackColor = true;
            ckbTrack3.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbTrack2
            // 
            ckbTrack2.AutoSize = true;
            ckbTrack2.Dock = DockStyle.Fill;
            ckbTrack2.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbTrack2.Location = new Point(128, 3);
            ckbTrack2.Name = "ckbTrack2";
            ckbTrack2.Size = new Size(119, 94);
            ckbTrack2.TabIndex = 1;
            ckbTrack2.Tag = "center";
            ckbTrack2.Text = "Track 2";
            ckbTrack2.UseVisualStyleBackColor = true;
            ckbTrack2.CheckedChanged += CheckedChangeHandle;
            // 
            // ckbTrack1
            // 
            ckbTrack1.AutoSize = true;
            ckbTrack1.Dock = DockStyle.Fill;
            ckbTrack1.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbTrack1.Location = new Point(3, 3);
            ckbTrack1.Name = "ckbTrack1";
            ckbTrack1.Size = new Size(119, 94);
            ckbTrack1.TabIndex = 0;
            ckbTrack1.Tag = "center";
            ckbTrack1.Text = "Track 1";
            ckbTrack1.UseVisualStyleBackColor = true;
            ckbTrack1.CheckedChanged += CheckedChangeHandle;
            // 
            // TrackPickerUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TrackPickerUC";
            Size = new Size(500, 100);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox ckbTrack1;
        private CheckBox ckbTrack4;
        private CheckBox ckbTrack3;
        private CheckBox ckbTrack2;
    }
}
