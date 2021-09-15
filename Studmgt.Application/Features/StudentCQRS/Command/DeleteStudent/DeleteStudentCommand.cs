using MediatR;
using System;

namespace Studmgt.Application.Features.StudentCQRS.Command.DeleteStudent
{

    public class DeleteStudentCommand : IRequest
        {
            public int ID { get; set; }
        }
    }
