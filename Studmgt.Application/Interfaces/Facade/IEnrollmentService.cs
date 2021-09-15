
using Studmgt.Application.Dtos;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface IEnrollmentService
    {
        Task<ResponseDto<EnrollmentDto>> GetById(int id);
        Task<ResponseDto<EnrollmentDto>> GetAll();
        Task<ResponseDto<EnrollmentDto>> Create(EnrollmentDto member);
        ResponseDto<EnrollmentDto> Update(EnrollmentDto member);
        ResponseDto<EnrollmentDto> Delete(int id);
    }
}
