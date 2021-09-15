using MediatR;
using Studmgt.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.StudentCQRS.Queries.GetStudentList
{

    public class GetStudentListQuery : IRequest<List<StudentDto>>
    {
        public string Name { get; set; }

        public GetStudentListQuery(string SName)
        {
            Name = SName ?? throw new ArgumentNullException(nameof(SName));
        }
    }
}
