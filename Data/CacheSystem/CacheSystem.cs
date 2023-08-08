#nullable enable
using System;
using Microsoft.Extensions.Caching.Memory;

namespace Kamall_foods_server_aspNetCore.Data.CacheSystem;

public class CacheSystem : ICacheSystem
{
    private readonly IMemoryCache _memoryCache;

    public CacheSystem(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public TValue Get<TValue>(string key)
    {
        _memoryCache.TryGetValue<TValue>(key, out var value);
        return value;
    }

    public bool Set<TValue>(string key, TValue value)
    {
        var cacheExpiryOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpiration = DateTime.Now.AddDays(1),
            Priority = CacheItemPriority.High,
            SlidingExpiration = TimeSpan.FromDays(1)
        };

        return _memoryCache.Set(key, value, cacheExpiryOptions) != null;
    }
}