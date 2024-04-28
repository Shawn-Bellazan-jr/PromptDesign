using Architecture.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Infrastructure.Data
{
    public class DataService<T> : IDataService<T>
    {
        public Task<T?> AddAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<T?> ExistAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
