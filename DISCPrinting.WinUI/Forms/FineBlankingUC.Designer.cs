namespace DISCPrinting.WinUI.Forms
{
    partial class FineBlankingUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FineBlankingUC));
            imageList1 = new ImageList(components);
            tbcFB = new TabControl();
            tbpNewBatch = new TabPage();
            tbpRePrint = new TabPage();
           
            tbpCombine = new TabPage();
            
            tbpCombineHistory = new TabPage();
            
            tbcFB.SuspendLayout();
            tbpRePrint.SuspendLayout();
            
            tbpCombine.SuspendLayout();
           
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ink_eraser_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(1, "history_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(2, "new_window_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(3, "print_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(4, "join_30dp_2854C5_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // tbcFB
            // 
            tbcFB.Controls.Add(tbpNewBatch);
            tbcFB.Controls.Add(tbpRePrint);
            tbcFB.Controls.Add(tbpCombine);
            tbcFB.Controls.Add(tbpCombineHistory);
            tbcFB.Dock = DockStyle.Fill;
            tbcFB.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbcFB.ImageList = imageList1;
            tbcFB.ItemSize = new Size(113, 33);
            tbcFB.Location = new Point(0, 0);
            tbcFB.Margin = new Padding(3, 4, 3, 4);
            tbcFB.Name = "tbcFB";
            tbcFB.SelectedIndex = 0;
            tbcFB.Size = new Size(604, 757);
            tbcFB.TabIndex = 10;
            tbcFB.SelectedIndexChanged += tbcFB_SelectedIndexChanged;
            // 
            // tbpNewBatch
            // 
            tbpNewBatch.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tbpNewBatch.ImageIndex = 2;
            tbpNewBatch.Location = new Point(4, 37);
            tbpNewBatch.Margin = new Padding(3, 4, 3, 4);
            tbpNewBatch.Name = "tbpNewBatch";
            tbpNewBatch.Padding = new Padding(3, 4, 3, 4);
            tbpNewBatch.Size = new Size(596, 716);
            tbpNewBatch.TabIndex = 0;
            tbpNewBatch.Text = "New Batch";
            tbpNewBatch.UseVisualStyleBackColor = true;
            // 
            // tbpRePrint
            // 
            tbpRePrint.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tbpRePrint.ImageIndex = 1;
            tbpRePrint.Location = new Point(4, 37);
            tbpRePrint.Margin = new Padding(3, 4, 3, 4);
            tbpRePrint.Name = "tbpRePrint";
            tbpRePrint.Padding = new Padding(3, 4, 3, 4);
            tbpRePrint.Size = new Size(596, 716);
            tbpRePrint.TabIndex = 1;
            tbpRePrint.Text = "Re-print";
            tbpRePrint.UseVisualStyleBackColor = true;
          
            tbpCombine.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tbpCombine.ImageIndex = 4;
            tbpCombine.Location = new Point(4, 37);
            tbpCombine.Margin = new Padding(3, 4, 3, 4);
            tbpCombine.Name = "tbpCombine";
            tbpCombine.Padding = new Padding(3, 4, 3, 4);
            tbpCombine.Size = new Size(596, 716);
            tbpCombine.TabIndex = 2;
            tbpCombine.Text = "Combine";
            tbpCombine.UseVisualStyleBackColor = true;
          
            tbpCombineHistory.Font = new Font("Bosch Office Sans", 9.75F, FontStyle.Bold);
            tbpCombineHistory.ImageIndex = 1;
            tbpCombineHistory.Location = new Point(4, 37);
            tbpCombineHistory.Margin = new Padding(3, 4, 3, 4);
            tbpCombineHistory.Name = "tbpCombineHistory";
            tbpCombineHistory.Padding = new Padding(3, 4, 3, 4);
            tbpCombineHistory.Size = new Size(596, 716);
            tbpCombineHistory.TabIndex = 3;
            tbpCombineHistory.Text = "History";
            tbpCombineHistory.UseVisualStyleBackColor = true;
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcFB);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FineBlankingUC";
            Size = new Size(604, 757);
            tbcFB.ResumeLayout(false);
            tbpRePrint.ResumeLayout(false);
           
            tbpCombine.ResumeLayout(false);
       
            tbpCombineHistory.ResumeLayout(false);
          
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TabControl tbcFB;
        private TabPage tbpNewBatch;
        private TabPage tbpRePrint;
        private TabPage tbpCombine;
        private TabPage tbpCombineHistory;
    }
}
