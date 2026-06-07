namespace DISCPrinting.WinUI.Forms.CommonUC
{
    partial class PrintCommandUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintCommandUC));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPrint = new Button();
            btnClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.980198F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.51485F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.51485F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.990099F));
            tableLayoutPanel1.Controls.Add(btnPrint, 2, 1);
            tableLayoutPanel1.Controls.Add(btnClear, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.Size = new Size(552, 85);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.Font = new Font("Bosch Office Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = ContentAlignment.MiddleRight;
            btnPrint.Location = new Point(280, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(261, 77);
            btnPrint.TabIndex = 1;
            btnPrint.Tag = "btn-lg";
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Bosch Office Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(13, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(261, 77);
            btnClear.TabIndex = 0;
            btnClear.Tag = "btn-lg";
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // PrintCommandUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PrintCommandUC";
            Size = new Size(552, 85);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClear;
        private Button btnPrint;
    }
}
