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
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        async Task<Student> IAsyncRepository<Student>.AddAsync(Student _object)
        {
            var member = await _dbContext.Students.AddAsync(_object);
            _dbContext.SaveChanges();
            return member.Entity;
        }

        bool IAsyncRepository<Student>.Delete(int id)
        {
            _dbContext.Students.Remove(_dbContext.Students.Find(id));
            _dbContext.SaveChanges();
            return true;
        }

        async Task<IEnumerable<Student>> IAsyncRepository<Student>.GetAllAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }

        async Task<Student> IAsyncRepository<Student>.GetByIdAsync(int id)
        {
            return await _dbContext.Students.FindAsync(id);
        }

        Task<IEnumerable<Student>> IStudentRepository.GetStudentByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        bool IAsyncRepository<Student>.Update(Student _object)
        {
            _dbContext.Update(_object);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
