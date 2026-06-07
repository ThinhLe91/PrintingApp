namespace DISCPrinting.WinUI.Forms
{
    partial class SettingUC
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
            dgvSetting = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSetting).BeginInit();
            SuspendLayout();
            // 
            // dgvSetting
            // 
            dgvSetting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSetting.Dock = DockStyle.Fill;
            dgvSetting.Location = new Point(0, 0);
            dgvSetting.Name = "dgvSetting";
            dgvSetting.Size = new Size(402, 272);
            dgvSetting.TabIndex = 0;
            // 
            // SettingUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvSetting);
            Name = "SettingUC";
            Size = new Size(402, 272);
            Load += SettingUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSetting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSetting;
    }
}
