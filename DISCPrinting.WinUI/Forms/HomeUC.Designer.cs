namespace DISCPrinting.WinUI.Forms
{
    partial class HomeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUC));
            btnFineBlanking = new Button();
            imageList1 = new ImageList(components);
            btnPrepareCoating = new Button();
            btnAOI = new Button();
            tlpLayout = new TableLayoutPanel();
            tlpLayout.SuspendLayout();
            SuspendLayout();
            // 
            // btnFineBlanking
            // 
            btnFineBlanking.BackColor = SystemColors.GradientInactiveCaption;
            btnFineBlanking.Dock = DockStyle.Fill;
            btnFineBlanking.Font = new Font("Bosch Office Sans", 14.25F, FontStyle.Bold);
            btnFineBlanking.ForeColor = Color.Black;
            btnFineBlanking.ImageAlign = ContentAlignment.MiddleLeft;
            btnFineBlanking.ImageIndex = 1;
            btnFineBlanking.ImageList = imageList1;
            btnFineBlanking.Location = new Point(16, 47);
            btnFineBlanking.Margin = new Padding(10);
            btnFineBlanking.Name = "btnFineBlanking";
            btnFineBlanking.Padding = new Padding(11, 0, 0, 0);
            btnFineBlanking.Size = new Size(570, 207);
            btnFineBlanking.TabIndex = 2;
            btnFineBlanking.Tag = "btn-lg";
            btnFineBlanking.Text = "Fine Blanking";
            btnFineBlanking.UseVisualStyleBackColor = false;
            btnFineBlanking.Click += btnFineBlanking_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "settings_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(1, "library_books_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(2, "pallet_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(3, "package_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // btnPrepareCoating
            // 
            btnPrepareCoating.BackColor = SystemColors.GradientInactiveCaption;
            btnPrepareCoating.Dock = DockStyle.Fill;
            btnPrepareCoating.Font = new Font("Bosch Office Sans", 14.25F, FontStyle.Bold);
            btnPrepareCoating.ForeColor = Color.Black;
            btnPrepareCoating.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrepareCoating.ImageIndex = 2;
            btnPrepareCoating.ImageList = imageList1;
            btnPrepareCoating.Location = new Point(16, 274);
            btnPrepareCoating.Margin = new Padding(10);
            btnPrepareCoating.Name = "btnPrepareCoating";
            btnPrepareCoating.Padding = new Padding(11, 0, 0, 0);
            btnPrepareCoating.Size = new Size(570, 207);
            btnPrepareCoating.TabIndex = 3;
            btnPrepareCoating.Tag = "btn-lg";
            btnPrepareCoating.Text = "Preparation For Coating";
            btnPrepareCoating.UseVisualStyleBackColor = false;
            btnPrepareCoating.Click += btnPrepareCoating_Click;
            // 
            // btnAOI
            // 
            btnAOI.BackColor = SystemColors.GradientInactiveCaption;
            btnAOI.Dock = DockStyle.Fill;
            btnAOI.Font = new Font("Bosch Office Sans", 14.25F, FontStyle.Bold);
            btnAOI.ForeColor = Color.Black;
            btnAOI.ImageAlign = ContentAlignment.MiddleLeft;
            btnAOI.ImageIndex = 3;
            btnAOI.ImageList = imageList1;
            btnAOI.Location = new Point(16, 501);
            btnAOI.Margin = new Padding(10);
            btnAOI.Name = "btnAOI";
            btnAOI.Padding = new Padding(11, 0, 0, 0);
            btnAOI.Size = new Size(570, 207);
            btnAOI.TabIndex = 4;
            btnAOI.Tag = "btn-lg";
            btnAOI.Text = "AOI";
            btnAOI.UseVisualStyleBackColor = false;
            btnAOI.Click += btnAOI_Click;
            // 
            // tlpLayout
            // 
            tlpLayout.AutoSize = true;
            tlpLayout.ColumnCount = 3;
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tlpLayout.Controls.Add(btnFineBlanking, 1, 1);
            tlpLayout.Controls.Add(btnPrepareCoating, 1, 2);
            tlpLayout.Controls.Add(btnAOI, 1, 3);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold);
            tlpLayout.Location = new Point(0, 0);
            tlpLayout.Margin = new Padding(3, 4, 3, 4);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 5;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpLayout.Size = new Size(603, 757);
            tlpLayout.TabIndex = 5;
            // 
            // HomeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeUC";
            Size = new Size(603, 757);
            tlpLayout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFineBlanking;
        private Button btnPrepareCoating;
        private Button btnAOI;
        private TableLayoutPanel tlpLayout;
        private ImageList imageList1;
    }
}
