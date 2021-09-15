using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Studmgt.Infrastracture.Persistance;

namespace Studmgt.Application.Persistence
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        async Task<Department> IAsyncRepository<Department>.AddAsync(Department entity)
        {
            var member = await _dbContext.Departments.AddAsync(entity);
            _dbContext.SaveChanges();
            return member.Entity;
        }

        bool IAsyncRepository<Department>.Delete(int id)
        {
            _dbContext.Departments.Remove(_dbContext.Departments.Find(id));
            _dbContext.SaveChanges();
            return true;
        }

        async Task<IEnumerable<Department>> IAsyncRepository<Department>.GetAllAsync()
        {
            return await _dbContext.Departments.ToListAsync();
        }



        async Task<Department> IAsyncRepository<Department>.GetByIdAsync(int id)
        {
            return await _dbContext.Departments.FindAsync(id);
        }


        bool IAsyncRepository<Department>.Update(Department _object)
        {
            _dbContext.Update(_object);
            _dbContext.SaveChanges();
            return true;
        }


        Task<IEnumerable<Department>> IDepartmentRepository.GetDepartmentByDeptName(string deptName)
        {
            throw new NotImplementedException();
        }

        Task IDepartmentRepository.GetDepartmentByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
