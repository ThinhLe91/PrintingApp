namespace DISCPrinting.Domain.Authorizations;

public class SharedPermission : Permission
{
    public new const string Module = "Shared";

    [PermissionDetail(GroupName = "Role", Action = "Read", Description = "Can read list role")]
    public const short RoleRead = 1;
    [PermissionDetail(GroupName = "Role", Action = "Create", Description = "Can add role")]
    public const short RoleCreate = 2;
    [PermissionDetail(GroupName = "Role", Action = "Update", Description = "Can update role")]
    public const short RoleUpdate = 3;
    [PermissionDetail(GroupName = "Role", Action = "Delete", Description = "Can delete role")]
    public const short RoleDelete = 4;

    [PermissionDetail(GroupName = "RoleToPermission", Action = "Read", Description = "Can read list role to permission")]
    public const short RoleToPermissionRead = 10;
    [PermissionDetail(GroupName = "RoleToPermission", Action = "Update", Description = "Can update list role to permission")]
    public const short RoleToPermissionUpdate = 11;

    [PermissionDetail(GroupName = "UserByRole", Action = "Read", Description = "Can read list user of role")]
    public const short UserByRoleRead = 12;
    [PermissionDetail(GroupName = "UserByRole", Action = "Create", Description = "Can add user to role")]
    public const short UserByRoleCreate = 13;
    [PermissionDetail(GroupName = "UserByRole", Action = "Update", Description = "Can update user out of role")]
    public const short UserByRoleUpdate = 14;
    [PermissionDetail(GroupName = "UserByRole", Action = "Delete", Description = "Can delete user out of role")]
    public const short UserByRoleDelete = 15;

    [PermissionDetail(GroupName = "Setting", Action = "Update", Description = "Can update setting")]
    public const short SettingUpdate = 16;
}