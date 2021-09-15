using MediatR;
using Studmgt.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.CourseCQRS.Queries.GetCourseList
{
    class GetCourseListQuery : IRequest<List<CourseDto>>
    {
        public string Code { get; set; }

        public GetCourseListQuery(string CourseCode)
        {
            Code = CourseCode ?? throw new ArgumentNullException(nameof(CourseCode));
        }
    }
}
