using MediatR;
using System;

namespace Studmgt.Application.Features.DepartmentCQRS.Command.DeleteDepartment
{
    public class DeleteDepartmentCommand: IRequest
    {
        public int Id { get; set; }
    }
}
