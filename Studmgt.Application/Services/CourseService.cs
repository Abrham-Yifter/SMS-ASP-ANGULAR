using AutoMapper;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Application.Dtos;
using Studmgt.Application.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studmgt.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository; 
        private readonly ILogger<CourseService> _logger;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, ILogger<CourseService> logger, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _logger = logger;
            _mapper = mapper;
        }

        async Task<ResponseDto<CourseDto>> ICourseService.GetById(int id)
        {
            return new ResponseDto<CourseDto>(_mapper.Map<CourseDto>(await _courseRepository.GetByIdAsync(id)));
        }

        async Task<ResponseDto<CourseDto>> ICourseService.GetAll()
        {
            return new ResponseDto<CourseDto>((await _courseRepository.GetAllAsync()).Select(x => _mapper.Map<CourseDto>(x)).ToList());
        }

        async Task<ResponseDto<CourseDto>> ICourseService.Create(CourseDto member)
        {
            return new ResponseDto<CourseDto>(_mapper.Map<CourseDto>(await _courseRepository.AddAsync(_mapper.Map<Course>(member))), true, "Member Created Successfully");
        }

        ResponseDto<CourseDto> ICourseService.Update(CourseDto member)
        {
            throw new NotImplementedException();
        }

        ResponseDto<CourseDto> ICourseService.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

