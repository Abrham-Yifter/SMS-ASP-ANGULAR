using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.DepartmentCQRS.Command.DeleteDepartment
{
    public class DeleteDepartmentCommandHandler: IRequestHandler<DeleteDepartmentCommand>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger<DeleteDepartmentCommandHandler> _logger;
        public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository, ILogger<DeleteDepartmentCommandHandler> logger)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;
        }
        public async Task<Unit> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _departmentRepository.GetByIdAsync(request.Id);
            if (department == null)
            {
                throw new NotFoundException(nameof(Department), request.Id);
            }
            //await _departmentRepository.Delete(department);
            _logger.LogInformation($"Department {department.Id} is successfully deleted.");
            return Unit.Value;
        }

    }
}
