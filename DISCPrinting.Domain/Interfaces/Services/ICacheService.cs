using Microsoft.Extensions.Caching.Memory;

namespace DISCPrinting.Domain.Interfaces.Services;

public interface ICacheService
{
    bool Exist(string key);
    T? Get<T>(string key);
    void Remove(string key);
    T Set<T>(string key, T value, TimeSpan? expiredTime = null, bool? isSliding = false);
    bool TryGetValue<T>(string key, out T? value);
}
