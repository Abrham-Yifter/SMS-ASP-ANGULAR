using Studmgt.Domain.Enum;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Model
{
   public class Student: BaseAuditableModels
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public string StudentName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual IEnumerable<Enrollment> Enrollments { get; set; }

    }
}
