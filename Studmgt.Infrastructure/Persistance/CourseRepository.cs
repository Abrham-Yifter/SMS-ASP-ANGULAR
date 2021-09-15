
using Microsoft.EntityFrameworkCore;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using Studmgt.Infrastracture.Persistance;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Application.Persistence
{
    public class CourseRepository: ICourseRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CourseRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        async Task<Course> IAsyncRepository<Course>.AddAsync(Course _object)
        {
            var member = await _dbContext.Courses.AddAsync(_object);
            _dbContext.SaveChanges();
            return member.Entity;
        }

        bool IAsyncRepository<Course>.Delete(int id)
        {
            _dbContext.Courses.Remove(_dbContext.Courses.Find(id));
            _dbContext.SaveChanges();
            return true;
        }

        async Task<IEnumerable<Course>> IAsyncRepository<Course>.GetAllAsync()
        {
            return await _dbContext.Courses.ToListAsync();
        }

        async Task<Course> IAsyncRepository<Course>.GetByIdAsync(int id)
        {
            return await _dbContext.Courses.FindAsync(id);
        }

        async Task<List<Course>> ICourseRepository.GetCourseByCourseCode(string courseCode)
        {
            throw new NotImplementedException();
        }

        bool IAsyncRepository<Course>.Update(Course _object)
        {
            _dbContext.Update(_object);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
