namespace DISCPrinting.WinUI.Forms.CommonUC
{
    partial class MultiSelectComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiSelectComboBox));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDropdown = new Button();
            txtDisplay = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(btnDropdown, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDisplay, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(675, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDropdown
            // 
            btnDropdown.Dock = DockStyle.Top;
            btnDropdown.Image = (Image)resources.GetObject("btnDropdown.Image");
            btnDropdown.Location = new Point(638, 3);
            btnDropdown.Name = "btnDropdown";
            btnDropdown.Size = new Size(34, 34);
            btnDropdown.TabIndex = 0;
            btnDropdown.UseVisualStyleBackColor = true;
            btnDropdown.Click += btnDropdown_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Dock = DockStyle.Top;
            txtDisplay.Font = new Font("Bosch Office Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(0, 5);
            txtDisplay.Margin = new Padding(0, 5, 3, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(632, 28);
            txtDisplay.TabIndex = 1;
            // 
            // MultiSelectComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MultiSelectComboBox";
            Size = new Size(675, 40);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDropdown;
        private TextBox txtDisplay;
    }
}
