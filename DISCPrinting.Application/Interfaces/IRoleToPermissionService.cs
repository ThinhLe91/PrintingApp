using DISCPrinting.Application.Dtos.AuthorizeDtos;

namespace DISCPrinting.Application.Interfaces;

public interface IRoleToPermissionService
{
    Task<List<RoleWithPermissionDto>> GetRoleWithPermissions();
    Task<bool> SavePermissionInRole(string roleName, string[] permissionNames);
}
