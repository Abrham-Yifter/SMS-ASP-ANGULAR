using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.CourseCQRS.Command.CreateCourse
{
   public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, int>
    {
        private readonly ICourseRepository _courseRepository; 
        private readonly ILogger<CreateCourseCommandHandler> _logger;
        private readonly IMapper _mapper;
        public CreateCourseCommandHandler(ICourseRepository courseRepository, ILogger<CreateCourseCommandHandler> logger, IMapper mapper)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = _mapper.Map<Course>(request);
            var newCourse = await _courseRepository.AddAsync(course);
            _logger.LogInformation($"Course {newCourse.CourseCode} is successfully created.");
            return newCourse.Id;
        }
    }
}
