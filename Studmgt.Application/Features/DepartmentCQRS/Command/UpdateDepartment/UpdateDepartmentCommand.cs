using MediatR;
using Studmgt.Application.Dtos;
using System;

namespace Studmgt.Application.Features.DepartmentCQRS.Command.UpdateDepartment
{
    class UpdateDepartmentCommand: DepartmentDto, IRequest
    {
        public int Id { get; set; }
    }
}
