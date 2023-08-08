namespace Kamall_foods_server_aspNetCore.Data.CacheSystem;

public interface ICacheSystem
{
    public TValue Get<TValue>(string key);
    public bool Set<TValue>(string key, TValue value);
}