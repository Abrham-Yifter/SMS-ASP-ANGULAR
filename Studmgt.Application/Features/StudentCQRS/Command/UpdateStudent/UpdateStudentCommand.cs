using MediatR;
using Studmgt.Application.Dtos;
using System;

namespace Studmgt.Application.Features.StudentCQRS.Command.UpdateStudent
{

    public class UpdateStudentCommand : StudentDto, IRequest
        {
            public int Id { get; set; }
        }

}

