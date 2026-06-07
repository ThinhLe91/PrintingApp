using DISCPrinting.Domain.ValueObjects;

namespace DISCPrinting.Domain.Interfaces.Services;

public interface IUserService
{
    string WindowUser { get; }
    UserInformation LoginUser { get; }
    bool IsAuthenticated { get; }

    UserInformation? GetUserByUsername(string username);
    Task<bool> Login(string username, string password);
    void Logout();
}
