using MediatR;
using System;

namespace Studmgt.Application.Features.CourseCQRS.Command.DeleteCourse
{
    public class DeleteCourseCommand : IRequest
    {
        public int Id { get; set; }
    }
}
