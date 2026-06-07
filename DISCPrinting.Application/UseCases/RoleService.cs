using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Application.UseCases;

public class RoleService(IUnitOfWork _uow) : IRoleService
{
    private readonly IGenericRepository<RoleEntity> _repository = _uow.GetRepository<RoleEntity>();

    public async Task<List<string>> GetRoles()
    {
        return await _repository.GetByConditionQueryable().OrderBy(_ => _.RoleName).Select(_ => _.RoleName).ToListAsync();
    }

    public async Task<bool> AddNewRole(string roleName)
    {
        if(string.IsNullOrEmpty(roleName))
            throw new ArgumentNullException(nameof(roleName));
        var check = await _repository.GetByConditionQueryable(_ => _.RoleName.ToLower() == roleName.ToLower()).FirstOrDefaultAsync();
        if (check != null)
            throw new Exception($"Role [{roleName}] is exist");
        await _repository.Insert(new RoleEntity
        {
            RoleName = roleName,
        });
        await _uow.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteRole(string roleName)
    {
        var check = await _repository.GetByConditionQueryable(_ => _.RoleName.ToLower() == roleName.ToLower()).FirstOrDefaultAsync();
        if (check == null)
            throw new Exception($"Role [{roleName}] is not exist");
        var checkUser = await _uow.GetRepository<UserRoleEntity>().GetByConditionQueryable(_ => _.RoleName.ToLower() == roleName.ToLower())
            .FirstOrDefaultAsync();
        if (checkUser != null)
            throw new Exception("There is a user assigned to this role. Please remove them before deleting the role.");
        check.IsDeleted = true;
        _repository.Update(check); 
        await _uow.SaveChangesAsync();
        return true;
    }
}
