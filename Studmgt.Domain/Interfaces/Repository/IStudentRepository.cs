using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Repository
{
 
        public interface IStudentRepository : IAsyncRepository<Student>
        {
        Task<IEnumerable<Student>> GetStudentByUserName(string userName);  

    }
    }

