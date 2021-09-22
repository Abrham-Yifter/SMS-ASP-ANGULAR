using Studmgt.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Application.Interfaces.Facade
{
   public interface IDepartmentService
    {
        Task<ResponseDto<DepartmentDto>> GetById(int id);
        Task<ResponseDto<DepartmentDto>> GetAll();
        Task<ResponseDto<DepartmentDto>> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize);
        Task<ResponseDto<DepartmentDto>> Create(DepartmentDto member);
        ResponseDto<DepartmentDto> Update(DepartmentDto member);
        ResponseDto<DepartmentDto> Delete(int id);

    }
}
