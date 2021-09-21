using Microsoft.EntityFrameworkCore;
using Studmgt.Application.Interfaces.Context;
using Studmgt.Domain.Model;

namespace Studmgt.Infrastracture.Persistance
{
    public class ApplicationDbContext: DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
