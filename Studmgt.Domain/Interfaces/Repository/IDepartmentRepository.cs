using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Repository
{
    public interface IDepartmentRepository: IAsyncRepository<Department>
    {
        Task<IEnumerable<Department>> GetDepartmentByDeptName(string deptName);
        Task GetDepartmentByName(string name);
    }
    
}
