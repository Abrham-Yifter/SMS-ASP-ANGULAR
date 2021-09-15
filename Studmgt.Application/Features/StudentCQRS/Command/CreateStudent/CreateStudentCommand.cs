using MediatR;
using Studmgt.Application.Dtos;
using System;

namespace Studmgt.Application.Features.StudentCQRS.Command.CreateStudent
{
    public class CreateStudentCommand : StudentDto, IRequest<int>
    {
        public int Id { get; set; }
    }
}

