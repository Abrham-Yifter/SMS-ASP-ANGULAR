using Studmgt.Domain.Model;
using System.Collections.Generic;

namespace Studmgt.Application.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int DepartmentId { get; set; }
        //public virtual IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
