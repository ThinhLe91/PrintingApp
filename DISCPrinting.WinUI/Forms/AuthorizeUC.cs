using DISCPrinting.Application.Dtos.AuthorizeDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.WinUI.Forms
{
    public partial class AuthorizeUC : BaseUserControl
    {
        public override string PageTitle => "Authorize";
        private List<RoleWithPermissionDto> roles = new();
        private bool isUpdatingPermissionTreeView = false;
        private List<UserWithRoleDto> users = new();
        public AuthorizeUC(IServiceScopeFactory serviceScope) : base(serviceScope)
        {
            InitializeComponent();
            lstRole.SelectedIndexChanged += LstRole_SelectedIndexChanged;
        }

        #region Event

        private void AuthorizeUC_Load(object sender, EventArgs e)
        {
            LoadRoleList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoleName.Text = "";
            btnClear.Enabled = false;
        }

        private async void btnAddRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoleName.Text))
            {
                MessageBox.Show("Please input role name", "Notification");
            }
            else
            {
                var res = await ExecuteServiceAsync<IRoleService, bool>(_ => _.AddNewRole(txtRoleName.Text));
                if (res)
                {
                    txtRoleName.Text = "";
                    btnClear.Enabled = false;
                    LoadRoleList();
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (lstRole.SelectedItem is RoleWithPermissionDto selectedRole)
            {
                RoleWithPermissionDto role = roles.First(_ => _.RoleName == selectedRole.RoleName);
                List<string> permissionNames = new List<string>();
                foreach (TreeNode moduleNode in tvPermissions.Nodes)
                {
                    foreach (TreeNode groupNode in moduleNode.Nodes)
                    {
                        foreach (TreeNode actionNode in groupNode.Nodes)
                        {
                            if (actionNode.Checked)
                                permissionNames.Add(actionNode.Tag as string);
                        }
                    }
                }
                var res = await ExecuteServiceAsync<IRoleToPermissionService, bool>(_ => _.SavePermissionInRole(role.RoleName, permissionNames.ToArray()));
                if (res)
                {
                    LoadRoleList();
                }
            }
            else
            {
                MessageBox.Show("Please choose role to edit!");
            }
        }

        private void tabAuthorize_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage currentTab = tabAuthorize.SelectedTab;
            if (currentTab != null)
            {
                if (currentTab == tabUser)
                {
                    LoadUsers();
                }
            }
        }

        #endregion

        #region Role List

        private void LstRole_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstRole.SelectedItem is RoleWithPermissionDto selectedRole)
            {
                LoadPermisison(selectedRole.Permissions);
                btnClear.Enabled = true;
            }
            else
            {
                tvPermissions.Nodes.Clear();
                btnClear.Enabled = false;
            }
        }

        private async void LoadRoleList()
        {
            roles = await ExecuteServiceAsync<IRoleToPermissionService, List<RoleWithPermissionDto>>(_ => _.GetRoleWithPermissions());
            lstRole.BeginUpdate();
            clstRole.BeginUpdate();
            lstRole.Items.Clear();
            clstRole.Items.Clear();
            foreach (var item in roles)
            {
                lstRole.Items.Add(item);
                clstRole.Items.Add(item);
            }
            clstRole.EndUpdate();
            lstRole.EndUpdate();
            if (lstRole.Items.Count > 0)
                lstRole.SelectedIndex = 0;
        }

        private async void deleteRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstRole.SelectedItem is RoleWithPermissionDto selectedRole)
            {
                var confirm = MessageBox.Show($"Do you want to delete role [{selectedRole.RoleName}]?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var res = await ExecuteServiceAsync<IRoleService, bool>(_ => _.DeleteRole(selectedRole.RoleName));
                    if (res)
                    {
                        LoadRoleList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose role to delete!");
            }
        }

        private void lstRole_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = lstRole.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lstRole.SelectedIndex = index;
                }
                else
                {
                    lstRole.SelectedIndex = -1;
                }
            }
        }

        private void cmsListRole_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lstRole.SelectedIndex == -1)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Permission TreeView

        private void CheckParentNodeIfAllChildrenChecked(TreeNode parentNode)
        {
            if (parentNode.Nodes.Count > 0)
            {
                bool allChecked = true;
                foreach (TreeNode child in parentNode.Nodes)
                {
                    if (!child.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }
                parentNode.Checked = allChecked;
            }
        }

        private void LoadPermisison(List<PermissionTreeDto> permissions)
        {
            tvPermissions.Nodes.Clear();
            tvPermissions.CheckBoxes = true;
            tvPermissions.BeginUpdate();
            var moduleGroups = permissions.GroupBy(_ => _.ModuleName);
            foreach (var moduleGroup in moduleGroups)
            {
                TreeNode moduleNode = new TreeNode(moduleGroup.Key);
                var groupGroups = moduleGroup.GroupBy(_ => _.GroupName);
                foreach (var groupGroup in groupGroups)
                {
                    TreeNode groupNode = new TreeNode(groupGroup.Key);
                    foreach (var item in groupGroup)
                    {
                        TreeNode actionNode = new TreeNode(item.Action);
                        actionNode.Tag = item.Name;
                        actionNode.Checked = item.IsAllow;
                        groupNode.Nodes.Add(actionNode);
                    }
                    CheckParentNodeIfAllChildrenChecked(groupNode);
                    moduleNode.Nodes.Add(groupNode);
                }
                CheckParentNodeIfAllChildrenChecked(moduleNode);
                tvPermissions.Nodes.Add(moduleNode);
            }
            tvPermissions.ExpandAll();
            tvPermissions.EndUpdate();
        }

        private void CheckAllChildNodes(TreeNode node, bool isChecked)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;
                CheckAllChildNodes(child, isChecked);
            }
        }

        private void UpdateParentNodeState(TreeNode node)
        {
            TreeNode parent = node.Parent;
            if (parent != null)
            {
                bool allChecked = true;
                foreach (TreeNode sibling in parent.Nodes)
                {
                    if (!sibling.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }
                parent.Checked = allChecked;
                UpdateParentNodeState(parent);
            }
        }

        private void tvPermissions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (isUpdatingPermissionTreeView) return;

            isUpdatingPermissionTreeView = true;
            if (e.Node != null)
            {
                CheckAllChildNodes(e.Node, e.Node.Checked);
                UpdateParentNodeState(e.Node);
            }
            isUpdatingPermissionTreeView = false;
        }

        #endregion

        #region User tab
        private async void LoadUsers()
        {
            users = await ExecuteServiceAsync<IUserRoleService, List<UserWithRoleDto>>(_ => _.GetUserWithRole());
            dgvUser.DataSource = users;
        }

        #endregion

        private async void btnAssign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please input username");
            }
            else if (clstRole.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please choose role to assign");
            }
            else
            {
                var userInfo = ExecuteService<IUserService, UserInformation?>(_ => _.GetUserByUsername(txtUsername.Text));
                if (userInfo == null)
                {
                    MessageBox.Show($"User [{txtUsername.Text}] is not found");
                }
                else
                {
                    UserWithRoleDto user = new UserWithRoleDto()
                    {
                        Username = txtUsername.Text,
                        DisplayName = userInfo.DisplayName,
                        Roles = ""
                    };
                    foreach (var item in clstRole.CheckedItems)
                    {
                        if (item is RoleWithPermissionDto)
                        {
                            user.Roles += (item as RoleWithPermissionDto).RoleName + ",";
                        }
                    }
                    user.Roles = user.Roles.TrimEnd(',');
                    var res = await ExecuteServiceAsync<IUserRoleService, bool>(_ => _.AssignRoleToUser(user));
                    if (res)
                    {
                        txtUsername.Text = "";
                        LoadUsers();
                    }
                }
            }
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            CheckUser(txtUsername.Text);
        }

        private void CheckUser(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please input username");
            }
            else
            {
                var userInfo = ExecuteService<IUserService, UserInformation?>(_ => _.GetUserByUsername(username));
                if (userInfo == null)
                {
                    MessageBox.Show($"User [{username}] is not found");
                }
                else
                {
                    string message = $"""
                        User: {userInfo.Username + Environment.NewLine}
                        Display name: {userInfo.DisplayName}
                        """;
                    MessageBox.Show(message);
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUser(txtUsername.Text);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                var selectedItem = dgvUser.Rows[e.RowIndex].DataBoundItem as UserWithRoleDto;
                if (selectedItem != null)
                {
                    txtUsername.Text = selectedItem.Username;
                    for (int i = 0; i < clstRole.Items.Count; i++)
                    {
                        var item = clstRole.Items[i] as RoleWithPermissionDto;
                        if (item != null && selectedItem.Roles.Contains(item.RoleName))
                        {
                            clstRole.SetItemChecked(i, true);
                        }
                        else
                            clstRole.SetItemChecked(i, false);
                    }
                } 
                    
            }
        }
    }
}
