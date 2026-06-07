namespace DISCPrinting.WinUI.Forms
{
    partial class HeaderUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderUC));
            iconMoreVert = new PictureBox();
            lblTitle = new Label();
            lblDisplayUser = new Label();
            picPrinter = new PictureBox();
            picBack = new PictureBox();
            contextMenuStrip = new ContextMenuStrip(components);
            settingToolStripMenuItem = new ToolStripMenuItem();
            generalToolStripMenuItem = new ToolStripMenuItem();
            authorizeToolStripMenuItem = new ToolStripMenuItem();
            testPrintToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)iconMoreVert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPrinter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // iconMoreVert
            // 
            iconMoreVert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            iconMoreVert.BackColor = Color.Transparent;
            iconMoreVert.Image = (Image)resources.GetObject("iconMoreVert.Image");
            iconMoreVert.Location = new Point(557, 28);
            iconMoreVert.Margin = new Padding(3, 4, 3, 4);
            iconMoreVert.Name = "iconMoreVert";
            iconMoreVert.Size = new Size(34, 40);
            iconMoreVert.SizeMode = PictureBoxSizeMode.StretchImage;
            iconMoreVert.TabIndex = 0;
            iconMoreVert.TabStop = false;
            iconMoreVert.Click += iconMoreVert_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(57, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 93);
            lblTitle.TabIndex = 1;
            lblTitle.Tag = "header";
            lblTitle.Text = "DISC - PRINTING APP";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblDisplayUser
            // 
            lblDisplayUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDisplayUser.BackColor = Color.Transparent;
            lblDisplayUser.Font = new Font("Bosch Office Sans", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplayUser.ForeColor = Color.White;
            lblDisplayUser.Location = new Point(355, 0);
            lblDisplayUser.Name = "lblDisplayUser";
            lblDisplayUser.Size = new Size(206, 93);
            lblDisplayUser.TabIndex = 1;
            lblDisplayUser.Tag = "italic right";
            lblDisplayUser.Text = "External Hoang Thien (Amaris, HcP/ICO3)";
            lblDisplayUser.TextAlign = ContentAlignment.MiddleRight;
            lblDisplayUser.Click += lblDisplayUser_Click;
            // 
            // picPrinter
            // 
            picPrinter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picPrinter.BackColor = Color.Transparent;
            picPrinter.Image = (Image)resources.GetObject("picPrinter.Image");
            picPrinter.Location = new Point(16, 24);
            picPrinter.Margin = new Padding(3, 4, 3, 4);
            picPrinter.Name = "picPrinter";
            picPrinter.Size = new Size(34, 40);
            picPrinter.SizeMode = PictureBoxSizeMode.StretchImage;
            picPrinter.TabIndex = 2;
            picPrinter.TabStop = false;
            // 
            // picBack
            // 
            picBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picBack.BackColor = Color.Transparent;
            picBack.Image = (Image)resources.GetObject("picBack.Image");
            picBack.Location = new Point(16, 27);
            picBack.Margin = new Padding(3, 4, 3, 4);
            picBack.Name = "picBack";
            picBack.Size = new Size(34, 40);
            picBack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBack.TabIndex = 3;
            picBack.TabStop = false;
            picBack.Visible = false;
            picBack.Click += picBack_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem, testPrintToolStripMenuItem, toolStripSeparator1, logoutToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(159, 96);
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generalToolStripMenuItem, authorizeToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Padding = new Padding(0, 1, 0, 5);
            settingToolStripMenuItem.Size = new Size(158, 30);
            settingToolStripMenuItem.Text = "Setting";
            settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;
            // 
            // generalToolStripMenuItem
            // 
            generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            generalToolStripMenuItem.Size = new Size(178, 26);
            generalToolStripMenuItem.Text = "General";
            generalToolStripMenuItem.Click += generalToolStripMenuItem_Click;
            // 
            // authorizeToolStripMenuItem
            // 
            authorizeToolStripMenuItem.Name = "authorizeToolStripMenuItem";
            authorizeToolStripMenuItem.Size = new Size(178, 26);
            authorizeToolStripMenuItem.Text = "Authorize";
            authorizeToolStripMenuItem.Click += authorizeToolStripMenuItem_Click;
            // 
            // testPrintToolStripMenuItem
            // 
            testPrintToolStripMenuItem.Name = "testPrintToolStripMenuItem";
            testPrintToolStripMenuItem.Padding = new Padding(0, 1, 0, 5);
            testPrintToolStripMenuItem.Size = new Size(158, 30);
            testPrintToolStripMenuItem.Text = "TestPrint";
            testPrintToolStripMenuItem.Click += testPrintToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(158, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // HeaderUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(picBack);
            Controls.Add(picPrinter);
            Controls.Add(lblDisplayUser);
            Controls.Add(lblTitle);
            Controls.Add(iconMoreVert);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HeaderUC";
            Size = new Size(594, 93);
            ((System.ComponentModel.ISupportInitialize)iconMoreVert).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPrinter).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconMoreVert;
        private Label lblTitle;
        private Label lblDisplayUser;
        private PictureBox picPrinter;
        private PictureBox picBack;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem testPrintToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem generalToolStripMenuItem;
        private ToolStripMenuItem authorizeToolStripMenuItem;
    }
}
