using Microsoft.EntityFrameworkCore;
using Studmgt.Domain.Model;


namespace Studmgt.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
