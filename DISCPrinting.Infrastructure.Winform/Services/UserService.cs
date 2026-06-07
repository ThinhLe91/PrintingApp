using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;

namespace DISCPrinting.Infrastructure.Services;

public class UserService(ICacheService _cacheService, ISettingProvider _settingProvider) : IUserService
{
    public UserInformation LoginUser => _cacheService.Get<UserInformation>(CacheKey.LoginUser) ?? new();
    public bool IsAuthenticated => !string.IsNullOrEmpty(LoginUser.Username);
    public string WindowUser => $"{WindowsIdentity.GetCurrent().Name.Replace($"{Environment.UserDomainName}\\", "")}";


    #region Private function
    private async Task SetUserInfo(string username, string displayName)
    {
        var sessionExpireMinutes = await _settingProvider.GetByKey(SettingKeys.Global.SessionExpireMinutes);
        if (!int.TryParse(sessionExpireMinutes, out int minutes))
        {
            minutes = 15;
        }
        _cacheService.Set(CacheKey.LoginUser, new UserInformation()
        {
            Username = username,
            DisplayName = displayName
        }, TimeSpan.FromMinutes(minutes), true);
    }
    #endregion

    public async Task<bool> Login(string username, string password)
    {
        if (string.IsNullOrEmpty(username))
            throw new Exception("Username is invalid");
        username = username.Trim().ToUpper();
        string displayName = "";
        bool result = false;
        if (string.IsNullOrEmpty(password))
        {
            var currentIdentity = WindowsIdentity.GetCurrent();
            result = currentIdentity.Name.ToLower() == $"{Environment.UserDomainName}\\{username}".ToLower();
            displayName = UserPrincipal.Current.DisplayName;
        }
        else
        {
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                {
                    bool isValid = context.ValidateCredentials(username, password);

                    if (isValid)
                    {
                        UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                        displayName = user?.DisplayName ?? "";
                        result = true;
                    }
                }
            }
            catch (PrincipalServerDownException ex)
            {
                throw new Exception("Unable to connect to the authentication server. Please check your local network connection.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Authentication error: {ex.Message}", ex);
            }
        }
        if (result)
            await SetUserInfo(username, displayName);
        return result;
    }

    public void Logout()
    {
        _cacheService.Remove(CacheKey.LoginUser);
    }

    public UserInformation? GetUserByUsername(string username)
    {
        using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
        {
            using (UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username))
            {
                if (user != null)
                {
                    return new UserInformation
                    {
                        Username = username,
                        DisplayName = user.DisplayName
                    };
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
