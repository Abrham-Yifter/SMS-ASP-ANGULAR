using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.DepartmentCQRS.Command.CreateDepartment
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger<CreateDepartmentCommand> _logger;
        private readonly IMapper _mapper;
        public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository, ILogger<CreateDepartmentCommand> logger, IMapper mapper)
        {
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = _mapper.Map<Department>(request);
            var newDepartment = await _departmentRepository.AddAsync(department);
            _logger.LogInformation($"Department {newDepartment.Id} is successfully created.");
            return newDepartment.Id;
        }

    }
}
