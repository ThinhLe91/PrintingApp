using DISCPrinting.Application.Dtos.SettingDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace DISCPrinting.Application.UseCases;

public class SettingService(IUnitOfWork _uow, IUserService _userService, IClientProvider _clientService, IMapper _mapper) : ISettingService
{
    private readonly IGenericRepository<SettingEntity> _repository = _uow.GetRepository<SettingEntity>();

    public async Task<T> GetOrInitByKey<T>(string key, T defaultValue)
    {
        List<string> allowTypes = new List<string>() { "Int32", "Int64", "Single", "Double", "Decimal", "Boolean", "String" };
        bool isAllowType = allowTypes.Contains(typeof(T).Name);
        string client = _clientService.GetMachineGuid();
        var res = await _repository.GetByConditionQueryable(_ =>
            _.SettingKey.ToUpper() == key.ToUpper()
            && (_.ClientId == null || _.ClientId == client)
            && (_.User == null || _.User == _userService.LoginUser.Username)
            ).OrderByDescending(_ => _.Priority).FirstOrDefaultAsync();
        if (res == null)
        {
            res = new SettingEntity()
            {
                SettingKey = key.ToUpper(),
                SettingValue = isAllowType ? (string)Convert.ChangeType(defaultValue, typeof(string))! : JsonConvert.SerializeObject(defaultValue),
                UpdatedBy = "INIT"
            };
            if (key.ToUpper().Contains(nameof(SettingKeys.Client).ToUpper()))
                res.ClientId = client;
            if (key.ToUpper().Contains(nameof(SettingKeys.User).ToUpper()))
                res.User = _userService.LoginUser.Username;
            await _repository.Insert(res);
            await _uow.SaveChangesAsync();
        }
        else
        {
            return isAllowType ? (T)Convert.ChangeType(res.SettingValue, typeof(T)) : JsonConvert.DeserializeObject<T>(res.SettingValue)!;
        }
        return defaultValue;
    }

    public async Task<bool> Update(Guid id, string value)
    {
        var res = await _repository.GetById(id);
        if (res == null)
            throw new Exception($"Setting [{id}] is not exist");
        res.SettingValue = value ?? "";
        _repository.Update(res);
        await _uow.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Upsert(string scope, string key, string value)
    {
        string? client = scope == nameof(SettingKeys.Global) || scope == nameof(SettingKeys.User) ? null : _clientService.GetMachineGuid();
        string? user = scope == nameof(SettingKeys.Global) || scope == nameof(SettingKeys.Client) ? null : _userService.LoginUser.Username;
        value = value ?? "";
        var res = await _repository.GetByConditionQueryable(_ =>
            _.SettingKey.ToUpper() == ($"{scope}.{key}").ToUpper()
            && _.ClientId == client && _.User == user,
            _ => _.OrderByDescending(__ => __.Priority)
            ).FirstOrDefaultAsync();
        if (res == null)
        {
            if (scope != nameof(SettingKeys.Global))
            {
                res = await _repository.GetByConditionQueryable(_ => _.SettingKey.ToUpper() == ($"{scope}.{key}").ToUpper(),
                    _ => _.OrderByDescending(__ => __.Priority)).FirstOrDefaultAsync();
                if (res != null)
                {
                    var newSetting = new SettingEntity
                    {
                        ClientId = scope == nameof(SettingKeys.Client) ? client : null,
                        Priority = scope == nameof(SettingKeys.Client) ? 2 : 3,
                        SettingDescription = "",
                        SettingKey = $"{scope}.{key}",
                        SettingValue = value,
                        User = scope == nameof(SettingKeys.User) ? user : null
                    };
                    await _repository.Insert(newSetting);
                    await _uow.SaveChangesAsync();
                    return true;
                }
            }
            throw new Exception($"Setting [{key}] is not exist");
        }
        else
        {
            res.SettingValue = value;
            _repository.Update(res);
            await _uow.SaveChangesAsync();
            return true;
        }
    }

    public async Task<List<SettingOutputDto>> GetSettings()
    {
        var list = _mapper.Map<List<SettingOutputDto>>(await _repository.GetByCondition(orderBy: _ => _.OrderBy(__ => __.SettingKey)));
        foreach (var item in list)
        {
            item.Scope = item.SettingKey.Split('.')[0];
            item.SettingKey = item.SettingKey.Split('.')[1];
        }
        return list;
    }
}
