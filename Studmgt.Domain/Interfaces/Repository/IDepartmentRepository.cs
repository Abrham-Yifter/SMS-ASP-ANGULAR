using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Repository
{
    public interface IDepartmentRepository: IAsyncRepository<Department>
    {
        Task<IEnumerable<Department>> GetDepartmentByDeptName(string deptName);
        Task GetDepartmentByName(string name);
        public Task<IEnumerable<Department>> GetWithPredicateAsync(Expression<Func<Department, Boolean>> predicate, int pageIndex, int pageSize);
    }
    
}
