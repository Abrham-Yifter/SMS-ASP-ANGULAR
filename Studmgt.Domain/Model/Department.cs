
using Studmgt.Domain.Seeds;
using System.Collections.Generic;

namespace Studmgt.Domain.Model
{
    public class Department: BaseAuditableModels
    {
        public Department()
        {
            Courses = new HashSet<Course>();
        }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public string DepartmentDescription { get; set; }
        public virtual IEnumerable<Course> Courses { get; set; }
    }
}
