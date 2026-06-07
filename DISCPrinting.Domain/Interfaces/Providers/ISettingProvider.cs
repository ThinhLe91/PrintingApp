namespace DISCPrinting.Domain.Interfaces.Providers;

public interface ISettingProvider
{
    Task<string> GetByKey(string key, string? clientId = null, string? userLogin = null);
    Task<Dictionary<string, string>> GetByKeys(string[] keys, string? clientId = null, string? userLogin = null);
}
