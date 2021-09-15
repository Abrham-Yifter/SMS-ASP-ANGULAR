using MediatR;
using Studmgt.Application.Dtos;
using System;

namespace Studmgt.Application.Features.DepartmentCQRS.Command.CreateDepartment
{
    public class CreateDepartmentCommand : DepartmentDto, IRequest<int>
    {
        
    }
}
