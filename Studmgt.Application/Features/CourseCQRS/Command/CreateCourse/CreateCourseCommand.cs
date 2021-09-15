using MediatR;
using Studmgt.Application.Dtos;
using System;


namespace Studmgt.Application.Features.CourseCQRS.Command.CreateCourse
{
    public class CreateCourseCommand : CourseDto, IRequest<int> 
    {
        public int Id { get; set; }
    }
}
