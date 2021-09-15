using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Studmgt.Application.Dtos;

namespace Studmgt.Application.Interfaces.Facade
{
    public interface ICourseService
    {
        Task<ResponseDto<CourseDto>> GetById(int id);
        Task<ResponseDto<CourseDto>> GetAll();
        Task<ResponseDto<CourseDto>> Create(CourseDto member);
        ResponseDto<CourseDto> Update(CourseDto member);
        ResponseDto<CourseDto> Delete(int id);
    }
}
