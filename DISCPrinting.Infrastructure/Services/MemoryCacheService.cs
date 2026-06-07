using DISCPrinting.Domain.Interfaces.Services;
using Microsoft.Extensions.Caching.Memory;

namespace DISCPrinting.Infrastructure.Services;

public class MemoryCacheService : ICacheService
{
    private readonly IMemoryCache cache;

    public MemoryCacheService(IMemoryCache cache)
    {
        this.cache = cache;
    }

    public bool Exist(string key)
    {
        return cache.TryGetValue(key, out var value);
    }

    public T? Get<T>(string key)
    {
        return cache.Get<T>(key);
    }

    public bool TryGetValue<T>(string key, out T? value)
    {
        return cache.TryGetValue(key, out value);
    }

    public T Set<T>(string key, T value, TimeSpan? expirationTime = null, bool? isSliding = false)
    {
        if (isSliding == true && expirationTime.HasValue)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(expirationTime.Value);
            return cache.Set(key, value, cacheEntryOptions);
        }
        else
        {
            if (expirationTime.HasValue)
                return cache.Set(key, value, expirationTime.Value);
            return cache.Set(key, value);
        }
    }

    public void Remove(string key)
    {
        cache.Remove(key);
    }
}
