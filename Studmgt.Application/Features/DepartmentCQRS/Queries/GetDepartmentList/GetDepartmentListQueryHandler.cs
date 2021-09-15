using Studmgt.Domain.Interfaces.Repository;
using System;


namespace Studmgt.Application.Features.DepartmentCQRS.Queries.GetDepartmentList
{
    class GetDepartmentListQueryHandler
    {
        private readonly IDepartmentRepository _departmentRepository;
        public GetDepartmentListQueryHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
        }

    }
}
