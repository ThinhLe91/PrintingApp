using DISCPrinting.Application.Dtos.AuthorizeDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Application.UseCases;

public class UserRoleService(IUnitOfWork _uow) : IUserRoleService
{
    private readonly IGenericRepository<UserRoleEntity> _repository = _uow.GetRepository<UserRoleEntity>();
    private readonly IGenericRepository<UserEntity> _userRepository = _uow.GetRepository<UserEntity>();

    public async Task<List<UserWithRoleDto>> GetUserWithRole()
    {
        var userRoles = from user in _uow.GetRepository<UserEntity>().GetByConditionQueryable()
                        join userRole in _repository.GetByConditionQueryable() on user.Username equals userRole.Username
                        into userRoleGroup
                        select new UserWithRoleDto
                        {
                            Username = user.Username,
                            DisplayName = user.DisplayName,
                            Roles = string.Join(",", userRoleGroup.Select(_ => _.RoleName))
                        };

        return await userRoles.ToListAsync();
    }

    public async Task<bool> AssignRoleToUser(UserWithRoleDto input)
    {
        var user = await _userRepository.GetByConditionQueryable(_ => _.Username == input.Username).FirstOrDefaultAsync();
        if (user == null)
        {
            user = new UserEntity
            {
                Username = input.Username,
                DisplayName = input.DisplayName
            };
            await _userRepository.Insert(user);
        }
        var userRoles = await _repository.GetByConditionQueryable(_ => _.Username == input.Username).ToListAsync();
        if (userRoles.Count == 0)
        {
            await _repository.Insert(input.Roles.Split(',').Select(_ => new UserRoleEntity
            {
                Username = input.Username,
                RoleName = _
            }).ToList());
        }
        else
        {
            var roles = input.Roles.Split(",").ToList();
            foreach (var role in userRoles.Where(_ => !roles.Contains(_.RoleName)))
            {
                role.IsDeleted = true;
                _repository.Update(role);
            }
            foreach (var role in roles.Except(userRoles.Select(_ => _.RoleName)))
            {
                await _repository.Insert(new UserRoleEntity
                {
                    RoleName = role,
                    Username = input.Username
                });
            }
        }
        await _uow.SaveChangesAsync();
        return true;
    }
}
