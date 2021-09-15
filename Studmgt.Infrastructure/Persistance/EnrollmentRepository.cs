using Microsoft.EntityFrameworkCore;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using Studmgt.Infrastracture.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Application.Persistence
{
    public class EnrollmentRepository: IEnrollmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EnrollmentRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        async Task<Enrollment> IAsyncRepository<Enrollment>.AddAsync(Enrollment entity)
        {
            var member = await _dbContext.Enrollments.AddAsync(entity);
            _dbContext.SaveChanges();
            return member.Entity;
        }

        bool IAsyncRepository<Enrollment>.Delete(int id)
        {
            _dbContext.Enrollments.Remove(_dbContext.Enrollments.Find(id));
            _dbContext.SaveChanges();
            return true;
        }

        async Task<IEnumerable<Enrollment>> IAsyncRepository<Enrollment>.GetAllAsync()
        {
            return await _dbContext.Enrollments.ToListAsync();
        }

        async Task<Enrollment> IAsyncRepository<Enrollment>.GetByIdAsync(int id)
        {
            return await _dbContext.Enrollments.FindAsync(id);
        }

        bool IAsyncRepository<Enrollment>.Update(Enrollment _object)
        {
            _dbContext.Update(_object);
            _dbContext.SaveChanges();
            return true;
        }

    }
}
