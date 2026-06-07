namespace DISCPrinting.WinUI.Forms
{
    partial class LoginUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUC));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            lnkUsername = new LinkLabel();
            txtPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(629, 933);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bosch Office Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 93);
            label1.Name = "label1";
            label1.Size = new Size(434, 93);
            label1.TabIndex = 0;
            label1.Tag = "header center";
            label1.Text = "DISC PRINTING APP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(97, 190);
            panel1.Margin = new Padding(3, 4, 3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 462);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.555555F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(btnLogin, 2, 6);
            tableLayoutPanel2.Controls.Add(lnkUsername, 2, 2);
            tableLayoutPanel2.Controls.Add(txtPassword, 2, 5);
            tableLayoutPanel2.Controls.Add(label4, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 1, 5);
            tableLayoutPanel2.Controls.Add(txtUsername, 2, 4);
            tableLayoutPanel2.Controls.Add(label5, 1, 3);
            tableLayoutPanel2.Controls.Add(label2, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.782609F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.565217F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.217391F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Size = new Size(432, 460);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            tableLayoutPanel2.SetColumnSpan(pictureBox1, 4);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogin.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(273, 377);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkUsername
            // 
            lnkUsername.AutoSize = true;
            lnkUsername.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkUsername.Location = new Point(169, 161);
            lnkUsername.Name = "lnkUsername";
            lnkUsername.Size = new Size(147, 22);
            lnkUsername.TabIndex = 4;
            lnkUsername.TabStop = true;
            lnkUsername.Tag = "header";
            lnkUsername.Text = "APAC/HHT8HC";
            lnkUsername.LinkClicked += lnkUsername_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(169, 325);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(234, 30);
            txtPassword.TabIndex = 2;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 161);
            label4.Name = "label4";
            label4.Size = new Size(137, 69);
            label4.TabIndex = 0;
            label4.Text = "Login with";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 321);
            label3.Name = "label3";
            label3.Size = new Size(137, 44);
            label3.TabIndex = 0;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(169, 280);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(234, 30);
            txtUsername.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(26, 230);
            label5.Name = "label5";
            label5.Size = new Size(377, 46);
            label5.TabIndex = 0;
            label5.Text = "Or use and other account:";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 276);
            label2.Name = "label2";
            label2.Size = new Size(137, 45);
            label2.TabIndex = 0;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // LoginUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginUC";
            Size = new Size(629, 933);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Button btnLogin;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private LinkLabel lnkUsername;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
