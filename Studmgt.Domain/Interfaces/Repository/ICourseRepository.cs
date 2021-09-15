using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Repository
{
   public interface ICourseRepository: IAsyncRepository<Course>
    {
        Task<List<Course>> GetCourseByCourseCode(string courseCode);
    }
}
