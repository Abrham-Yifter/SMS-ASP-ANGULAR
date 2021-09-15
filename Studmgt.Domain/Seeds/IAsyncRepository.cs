using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Seeds
{
  public interface IAsyncRepository <T> where T:BaseAuditableModels
    {
        public Task<T> AddAsync(T _object);
        public bool Update(T _object);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public bool Delete(int id);

    }
}
