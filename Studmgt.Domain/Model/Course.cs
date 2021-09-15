using Studmgt.Domain.Seeds;
using System.Collections.Generic;

namespace Studmgt.Domain.Model
{
    public class Course : BaseAuditableModels
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
