using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.EnrollmentCQRS.Command.CreateEnrollment
{
    public class CreateEnrollmentCommandHandler: IRequestHandler<CreateEnrollmentCommand, int>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ILogger<CreateEnrollmentCommand> _logger;
        private readonly IMapper _mapper;

        public CreateEnrollmentCommandHandler(IEnrollmentRepository enrollmentRepository, ILogger<CreateEnrollmentCommand> logger, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository ?? throw new ArgumentNullException(nameof(enrollmentRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateEnrollmentCommand request, CancellationToken cancellationToken)
        {
            var enrollment = _mapper.Map<Enrollment>(request);
            var newEnrollment = await _enrollmentRepository.AddAsync(enrollment);
            _logger.LogInformation($"Enrollment {newEnrollment.Id} is successfully created.");
            return newEnrollment.Id;
        }
    }
}
