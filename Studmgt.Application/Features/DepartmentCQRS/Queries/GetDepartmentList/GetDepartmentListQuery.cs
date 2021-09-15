using MediatR;
using Studmgt.Application.Dtos;
using System;
using System.Collections.Generic;

namespace Studmgt.Application.Features.DepartmentCQRS.Queries.GetDepartmentList
{
    class GetDepartmentListQuery:IRequest<List<DepartmentDto>>
    {
        public string Name { get; set; }
        public GetDepartmentListQuery(string departmentName)
        {
            Name = departmentName ?? throw new ArgumentNullException(nameof(departmentName));
        }
    }
}
