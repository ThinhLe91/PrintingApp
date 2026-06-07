using DISCPrinting.Application.Dtos.AuthorizeDtos;

namespace DISCPrinting.Application.Interfaces;

public interface IUserRoleService
{
    Task<bool> AssignRoleToUser(UserWithRoleDto input);
    Task<List<UserWithRoleDto>> GetUserWithRole();
}
