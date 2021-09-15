using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.DepartmentCQRS.Command.UpdateDepartment
{
    class UpdateDepartmentCommandHandler: IRequestHandler<UpdateDepartmentCommand>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger<UpdateDepartmentCommand> _logger;
        private readonly IMapper _mapper;

        public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, ILogger<UpdateDepartmentCommand> logger, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {

            var departmentToUpdate = await _departmentRepository.GetByIdAsync(request.Id);
            if (departmentToUpdate == null)
            {
                throw new NotFoundException(nameof(Department), request.Id);
            }
            var model = _mapper.Map<Department>(request);
            //await _departmentRepository.Update(model);
            _logger.LogInformation($"Department {departmentToUpdate.Id} is successfully updated.");
            return Unit.Value;

        }

    }
}
