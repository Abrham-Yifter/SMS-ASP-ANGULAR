using MediatR;
using Studmgt.Application.Dtos;
using System;

namespace Studmgt.Application.Features.EnrollmentCQRS.Command.CreateEnrollment
{
    public class CreateEnrollmentCommand : EnrollmentDto, IRequest<int>
    {
    }
}
