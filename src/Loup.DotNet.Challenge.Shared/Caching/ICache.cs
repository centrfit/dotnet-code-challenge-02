using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Loup.DotNet.Challenge.Shared.Caching
{
    public interface ICache<TKey, TValue> where TKey : struct
                                          where TValue : class
    {
        Task InsertAsync(TKey key, TValue value);

        Task<TValue> GetAsync(TKey key);

        Task<IEnumerable<TValue>> ListAsync();

        Task UpdateAsync(TKey key, TValue value);

        Task DeleteAsync(TKey key);
    }
}
