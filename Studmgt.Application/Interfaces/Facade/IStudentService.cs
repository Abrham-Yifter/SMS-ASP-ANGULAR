using Studmgt.Application.Dtos;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface IStudentService
    {
        Task<ResponseDto<StudentDto>> GetById(int id);
        Task<ResponseDto<StudentDto>> GetAll();
        Task<ResponseDto<StudentDto>> Create(StudentDto member);
        ResponseDto<StudentDto> Update(StudentDto member);
        ResponseDto<StudentDto> Delete(int id);

    }
}
