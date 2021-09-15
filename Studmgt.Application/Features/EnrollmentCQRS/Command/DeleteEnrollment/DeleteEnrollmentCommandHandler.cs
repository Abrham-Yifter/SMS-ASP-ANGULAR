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

namespace Studmgt.Application.Features.EnrollmentCQRS.Command.DeleteEnrollment
{
    class DeleteEnrollmentCommandHandler : IRequestHandler<DeleteEnrollmentCommand>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ILogger<DeleteEnrollmentCommandHandler> _logger;
        public DeleteEnrollmentCommandHandler(IEnrollmentRepository enrollmentRepository, ILogger<DeleteEnrollmentCommandHandler> logger)
        {
            _enrollmentRepository = enrollmentRepository;
            _logger = logger;
        }
        public async Task<Unit> Handle(DeleteEnrollmentCommand request, CancellationToken cancellationToken)
        {
            var enrollment = await _enrollmentRepository.GetByIdAsync(request.Id);
            if (enrollment == null)
            {
                throw new NotFoundException(nameof(Enrollment), request.Id);
            }
            //await _enrollmentRepository.Delete(enrollment);
            _logger.LogInformation($"Enrollment {enrollment.Id} is successfully deleted.");
            return Unit.Value;
        }

    }
}
