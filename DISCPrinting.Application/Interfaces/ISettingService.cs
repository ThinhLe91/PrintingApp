using DISCPrinting.Application.Dtos.SettingDtos;

namespace DISCPrinting.Application.Interfaces;

public interface ISettingService
{
    Task<T> GetOrInitByKey<T>(string key, T defaultValue);
    Task<List<SettingOutputDto>> GetSettings();
    Task<bool> Upsert(string scope, string key, string value);
    Task<bool> Update(Guid id, string value);
}
