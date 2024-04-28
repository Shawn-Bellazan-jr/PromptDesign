using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Application.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAsync();
        Task<T?> GetAsync(T model);
        Task<T?> AddAsync(T model);
        Task<T?> ExistAsync(T model);
    }
}
