using DISCPrinting.Application.Dtos.AuthorizeDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Authorizations;
using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Application.UseCases;

public class RoleToPermissionService(IUnitOfWork _uow) : IRoleToPermissionService
{
    private readonly IGenericRepository<RoleToPermissionEntity> _repository = _uow.GetRepository<RoleToPermissionEntity>();
    public async Task<List<RoleWithPermissionDto>> GetRoleWithPermissions()
    {
        var allRoleToPermissions = await _repository.GetByCondition();
        var allPermissions = PermissionExtensions.SystemPermissions();
        var allRoles = await _uow.GetRepository<RoleEntity>().GetByConditionQueryable(orderBy: _ => _.OrderBy(__ => __.RoleName)).Select(_ => _.RoleName).ToListAsync();
        List<RoleWithPermissionDto> results = new List<RoleWithPermissionDto>();
        foreach (var role in allRoles)
        {
            var extratedRoleName = role.ExtractRoleName();
            results.Add(new RoleWithPermissionDto
            {
                RoleName = role,
                Permissions = allPermissions.Where(_ => _.ModuleName == extratedRoleName.Value.module).Select(_ => new PermissionTreeDto
                {
                    Action = _.Action,
                    IsAllow = false,
                    Description = _.Description,
                    GroupName = _.GroupName,
                    ModuleName = _.ModuleName,
                    Name = _.Name
                }).ToList()
            });
        }
        foreach (var roleToPermission in allRoleToPermissions)
        {
            var roleNameExtracted = roleToPermission.RoleName.ExtractRoleName();
            var allPermissionChars = roleToPermission.PermissionsInRole.ToCharArray();
            RoleWithPermissionDto roleWithPermissions = results.First(_ => _.RoleName == roleToPermission.RoleName);

            foreach (char charCode in allPermissionChars)
            {
                string permissionValue = roleNameExtracted.Value.module + Convert.ToInt16(charCode);
                PermissionDetail permissionInRole = permissionValue.PermissionByCombinedCode(allPermissions);
                if (permissionInRole != null)
                {
                    var check = roleWithPermissions.Permissions.FirstOrDefault(_ => _.GroupName == permissionInRole.GroupName
                        && _.ModuleName == permissionInRole.ModuleName && _.Action == permissionInRole.Action);
                    if (check != null)
                    {
                        check.IsAllow = true;
                    }
                }
            }
        }
        return results;
    }
    public async Task<bool> SavePermissionInRole(string roleName, string[] permissionNames)
    {
        var role = await _repository.GetByConditionQueryable(_ => _.RoleName.ToLower() == roleName.ToLower()).FirstOrDefaultAsync();
        var isNewRole = role == null;
        if (role == null)
        {
            role = new RoleToPermissionEntity
            {
                RoleName = roleName,
                Description = "",
                PermissionsInRole = ""
            };
            await _repository.Insert(role);
        }
        var extratedRoleName = role.RoleName.ExtractRoleName();
        var allPermissions = PermissionExtensions.SystemPermissions();
        role.PermissionsInRole = permissionNames.EncodePermission(extratedRoleName.Value.module, allPermissions);
        role.Description = permissionNames.Aggregate("", (s, name) => s + name + ",");
        if (!isNewRole)
            _repository.Update(role);
        await _uow.SaveChangesAsync();
        return true;
    }
}
