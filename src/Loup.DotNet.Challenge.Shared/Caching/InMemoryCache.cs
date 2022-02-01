namespace Loup.DotNet.Challenge.Shared.Caching
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InMemoryCache<TKey, TValue> : ICache<TKey, TValue> where TKey : struct
                                                                    where TValue : class
    {
        private static Lazy<Dictionary<TKey, TValue>> _Cache;
        static InMemoryCache()
        {
            _Cache = new Lazy<Dictionary<TKey, TValue>>(() => new Dictionary<TKey, TValue>());
        }

        public Task InsertAsync(TKey key, TValue value)
        {
            _Cache.Value.TryAdd(key, value);

            return Task.CompletedTask;
        }

        public Task<TValue?> GetAsync(TKey key)
        {
            var item = _Cache.Value.ContainsKey(key) ? _Cache.Value[key] : default;

            return Task.FromResult(item);
        }

        public Task<IEnumerable<TValue>> ListAsync()
        {
            IEnumerable<TValue> items = _Cache.Value.Values.ToList();

            return Task.FromResult(items);
        }

        public Task UpdateAsync(TKey key, TValue value)
        {
            if (_Cache.Value.ContainsKey(key))
                _Cache.Value[key] = value;

            return Task.CompletedTask;
        }

        public Task DeleteAsync(TKey key)
        {
            _Cache.Value.Remove(key, out _);

            return Task.CompletedTask;
        }
    }
}
