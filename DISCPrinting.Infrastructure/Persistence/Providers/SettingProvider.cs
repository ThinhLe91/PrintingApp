using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DISCPrinting.Infrastructure.Persistence.Providers;

public class SettingProvider(IUnitOfWork _uow, ICacheService _cacheService) : ISettingProvider
{
    private readonly IGenericRepository<SettingEntity> _repository = _uow.GetRepository<SettingEntity>();

    public async Task<string> GetByKey(string key, string? clientId = null, string? userLogin = null)
    {
        var setting = await _repository.GetByConditionQueryable(_ => _.SettingKey.ToLower() == key.ToLower()
            && ((_.ClientId == null && _.User == null)
                || (_.ClientId == clientId && _.User == null)
                || _.User == userLogin
            ), _ => _.OrderByDescending(__ => __.Priority)
        ).FirstOrDefaultAsync();
        return setting?.SettingValue ?? throw new Exception($"Setting key [{key}] is not found");
    }

    public async Task<Dictionary<string, string>> GetByKeys(string[] keys, string? clientId = null, string? userLogin = null)
    {
        var settingList = await _repository.GetByConditionQueryable(_ => keys.Contains(_.SettingKey)
            && ((_.ClientId == null && _.User == null)
                || (_.ClientId == clientId && _.User == null)
                || _.User == userLogin
            ), _ => _.OrderByDescending(__ => __.Priority)
            ).ToListAsync();
        return settingList.GroupBy(_ => _.SettingKey).Select(_ => _.First()).ToDictionary(_ => _.SettingKey, _ => _.SettingValue);
    }

}
