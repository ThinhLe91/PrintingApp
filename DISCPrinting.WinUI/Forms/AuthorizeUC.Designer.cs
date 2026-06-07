namespace DISCPrinting.WinUI.Forms
{
    partial class AuthorizeUC
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
            tabAuthorize = new TabControl();
            tabRole = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lstRole = new ListBox();
            cmsListRole = new ContextMenuStrip(components);
            deleteRoleToolStripMenuItem = new ToolStripMenuItem();
            tvPermissions = new TreeView();
            txtRoleName = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            btnAddRole = new Button();
            btnSave = new Button();
            tabUser = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            txtUsername = new TextBox();
            clstRole = new CheckedListBox();
            label3 = new Label();
            btnCheckUser = new Button();
            btnAssign = new Button();
            dgvUser = new DataGridView();
            tabAuthorize.SuspendLayout();
            tabRole.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            cmsListRole.SuspendLayout();
            tabUser.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // tabAuthorize
            // 
            tabAuthorize.Controls.Add(tabRole);
            tabAuthorize.Controls.Add(tabUser);
            tabAuthorize.Dock = DockStyle.Fill;
            tabAuthorize.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabAuthorize.Location = new Point(0, 0);
            tabAuthorize.Margin = new Padding(3, 4, 3, 4);
            tabAuthorize.Name = "tabAuthorize";
            tabAuthorize.SelectedIndex = 0;
            tabAuthorize.Size = new Size(603, 757);
            tabAuthorize.TabIndex = 0;
            tabAuthorize.SelectedIndexChanged += tabAuthorize_SelectedIndexChanged;
            // 
            // tabRole
            // 
            tabRole.Controls.Add(tableLayoutPanel1);
            tabRole.Location = new Point(4, 31);
            tabRole.Margin = new Padding(3, 4, 3, 4);
            tabRole.Name = "tabRole";
            tabRole.Padding = new Padding(3, 4, 3, 4);
            tabRole.Size = new Size(595, 722);
            tabRole.TabIndex = 0;
            tabRole.Text = "Roles";
            tabRole.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.39689F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.Controls.Add(lstRole, 0, 1);
            tableLayoutPanel1.Controls.Add(tvPermissions, 0, 2);
            tableLayoutPanel1.Controls.Add(txtRoleName, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel1.Controls.Add(btnAddRole, 3, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.67213F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.32787F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(589, 714);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lstRole
            // 
            tableLayoutPanel1.SetColumnSpan(lstRole, 4);
            lstRole.ContextMenuStrip = cmsListRole;
            lstRole.Dock = DockStyle.Fill;
            lstRole.FormattingEnabled = true;
            lstRole.Location = new Point(3, 53);
            lstRole.Margin = new Padding(3, 4, 3, 4);
            lstRole.Name = "lstRole";
            lstRole.Size = new Size(583, 237);
            lstRole.TabIndex = 0;
            lstRole.SelectedIndexChanged += LstRole_SelectedIndexChanged;
            lstRole.MouseDown += lstRole_MouseDown;
            // 
            // cmsListRole
            // 
            cmsListRole.ImageScalingSize = new Size(20, 20);
            cmsListRole.Items.AddRange(new ToolStripItem[] { deleteRoleToolStripMenuItem });
            cmsListRole.Name = "contextMenuStrip1";
            cmsListRole.Size = new Size(153, 28);
            cmsListRole.Opening += cmsListRole_Opening;
            // 
            // deleteRoleToolStripMenuItem
            // 
            deleteRoleToolStripMenuItem.Name = "deleteRoleToolStripMenuItem";
            deleteRoleToolStripMenuItem.Size = new Size(152, 24);
            deleteRoleToolStripMenuItem.Text = "Delete role";
            deleteRoleToolStripMenuItem.Click += deleteRoleToolStripMenuItem_Click;
            // 
            // tvPermissions
            // 
            tableLayoutPanel1.SetColumnSpan(tvPermissions, 4);
            tvPermissions.Dock = DockStyle.Fill;
            tvPermissions.Location = new Point(3, 298);
            tvPermissions.Margin = new Padding(3, 4, 3, 4);
            tvPermissions.Name = "tvPermissions";
            tvPermissions.Size = new Size(583, 364);
            tvPermissions.TabIndex = 1;
            tvPermissions.AfterCheck += tvPermissions_AfterCheck;
            // 
            // txtRoleName
            // 
            txtRoleName.Dock = DockStyle.Fill;
            txtRoleName.Font = new Font("Bosch Office Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoleName.Location = new Point(147, 8);
            txtRoleName.Margin = new Padding(7, 8, 7, 8);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(223, 34);
            txtRoleName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 49);
            label1.TabIndex = 2;
            label1.Text = "Role name:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(380, 4);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 41);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddRole
            // 
            btnAddRole.Dock = DockStyle.Fill;
            btnAddRole.Location = new Point(463, 4);
            btnAddRole.Margin = new Padding(3, 4, 3, 4);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(123, 41);
            btnAddRole.TabIndex = 4;
            btnAddRole.Text = "Add Role";
            btnAddRole.UseVisualStyleBackColor = true;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // btnSave
            // 
            tableLayoutPanel1.SetColumnSpan(btnSave, 2);
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(380, 670);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Permission";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabUser
            // 
            tabUser.Controls.Add(tableLayoutPanel2);
            tabUser.Location = new Point(4, 31);
            tabUser.Margin = new Padding(3, 4, 3, 4);
            tabUser.Name = "tabUser";
            tabUser.Padding = new Padding(3, 4, 3, 4);
            tabUser.Size = new Size(595, 722);
            tabUser.TabIndex = 1;
            tabUser.Text = "Users";
            tabUser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0031147F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.99689F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel2.Controls.Add(clstRole, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(btnCheckUser, 2, 0);
            tableLayoutPanel2.Controls.Add(btnAssign, 2, 1);
            tableLayoutPanel2.Controls.Add(dgvUser, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5121956F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80.48781F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 435F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.Size = new Size(589, 714);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 54);
            label2.TabIndex = 3;
            label2.Text = "User:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(95, 8);
            txtUsername.Margin = new Padding(7, 8, 7, 8);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(365, 30);
            txtUsername.TabIndex = 4;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // clstRole
            // 
            clstRole.Dock = DockStyle.Fill;
            clstRole.FormattingEnabled = true;
            clstRole.Location = new Point(91, 58);
            clstRole.Margin = new Padding(3, 4, 3, 4);
            clstRole.Name = "clstRole";
            clstRole.Size = new Size(373, 216);
            clstRole.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(82, 224);
            label3.TabIndex = 6;
            label3.Text = "Role:";
            // 
            // btnCheckUser
            // 
            btnCheckUser.Location = new Point(470, 4);
            btnCheckUser.Margin = new Padding(3, 4, 3, 4);
            btnCheckUser.Name = "btnCheckUser";
            btnCheckUser.Size = new Size(113, 43);
            btnCheckUser.TabIndex = 5;
            btnCheckUser.Text = "Check";
            btnCheckUser.UseVisualStyleBackColor = true;
            btnCheckUser.Click += btnCheckUser_Click;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(470, 58);
            btnAssign.Margin = new Padding(3, 4, 3, 4);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(113, 43);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvUser, 3);
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.Location = new Point(3, 282);
            dgvUser.Margin = new Padding(3, 4, 3, 4);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.ShowEditingIcon = false;
            dgvUser.Size = new Size(583, 428);
            dgvUser.TabIndex = 2;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // AuthorizeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAuthorize);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuthorizeUC";
            Size = new Size(603, 757);
            Load += AuthorizeUC_Load;
            tabAuthorize.ResumeLayout(false);
            tabRole.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            cmsListRole.ResumeLayout(false);
            tabUser.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAuthorize;
        private TabPage tabRole;
        private ListBox lstRole;
        private TabPage tabUser;
        private TableLayoutPanel tableLayoutPanel1;
        private TreeView tvPermissions;
        private Label label1;
        private TextBox txtRoleName;
        private Button btnClear;
        private Button btnAddRole;
        private Button btnSave;
        private ContextMenuStrip cmsListRole;
        private ToolStripMenuItem deleteRoleToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckedListBox clstRole;
        private DataGridView dgvUser;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Button btnCheckUser;
        private Button btnAssign;
    }
}
