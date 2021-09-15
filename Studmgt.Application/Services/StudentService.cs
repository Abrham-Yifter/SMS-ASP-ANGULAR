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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentService> _logger;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, ILogger<StudentService> logger, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _logger = logger;
            _mapper = mapper;
        }

        async Task<ResponseDto<StudentDto>> IStudentService.Create(StudentDto member)
        {
            return new ResponseDto<StudentDto>(_mapper.Map<StudentDto>(await _studentRepository.AddAsync(_mapper.Map<Student>(member))), true, "Member Created Successfully");
        }

        ResponseDto<StudentDto> IStudentService.Update(StudentDto member)
        {
            throw new NotImplementedException();
        }

        ResponseDto<StudentDto> IStudentService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        async Task<ResponseDto<StudentDto>> IStudentService.GetById(int id)
        {
            return new ResponseDto<StudentDto>(_mapper.Map<StudentDto>(await _studentRepository.GetByIdAsync(id)));
        }

        async Task<ResponseDto<StudentDto>> IStudentService.GetAll()
        {
            return new ResponseDto<StudentDto>((await _studentRepository.GetAllAsync()).Select(x => _mapper.Map<StudentDto>(x)).ToList());
        }
    }
}
