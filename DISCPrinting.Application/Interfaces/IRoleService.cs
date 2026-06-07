
namespace DISCPrinting.Application.Interfaces;

public interface IRoleService
{
    Task<bool> AddNewRole(string roleName);
    Task<bool> DeleteRole(string roleName);
    Task<List<string>> GetRoles();
}
