using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.EnrollmentCQRS.Command.DeleteEnrollment
{
    class DeleteEnrollmentCommand : IRequest
    {
        public int Id { get; set; }
    }
}
