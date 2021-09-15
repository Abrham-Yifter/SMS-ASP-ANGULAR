using AutoMapper;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Dtos;
using Studmgt.Domain.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Studmgt.Application.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<EnrollmentService> _logger;
        public EnrollmentService(IEnrollmentRepository enrollmentRepository, ILogger<EnrollmentService> logger, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository;
            _logger = logger;
            _mapper = mapper;
        }
        async Task<ResponseDto<EnrollmentDto>> IEnrollmentService.Create(EnrollmentDto member)
        {
            return new ResponseDto<EnrollmentDto>(_mapper.Map<EnrollmentDto>(await _enrollmentRepository.AddAsync(_mapper.Map<Enrollment>(member))), true, "Member Created Successfully");
        }

        ResponseDto<EnrollmentDto> IEnrollmentService.Update(EnrollmentDto member)
        {
            throw new NotImplementedException();
        }

        ResponseDto<EnrollmentDto> IEnrollmentService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        async Task<ResponseDto<EnrollmentDto>> IEnrollmentService.GetById(int id)
        {
            return new ResponseDto<EnrollmentDto>(_mapper.Map<EnrollmentDto>(await _enrollmentRepository.GetByIdAsync(id)));
        }

        async Task<ResponseDto<EnrollmentDto>> IEnrollmentService.GetAll()
        {
            return new ResponseDto<EnrollmentDto>((await _enrollmentRepository.GetAllAsync()).Select(x => _mapper.Map<EnrollmentDto>(x)).ToList());
        }
    }
}
