using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.StudentCQRS.Command.DeleteStudent
{
    public class DeleteStudentCommandHandler: IRequestHandler<DeleteStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<DeleteStudentCommandHandler> _logger;
        public DeleteStudentCommandHandler(IStudentRepository studentRepository, ILogger<DeleteStudentCommandHandler> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }
        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.ID);
            if (student == null)
            {
                throw new NotFoundException(nameof(Student), request.ID);
            }
            //await _studentRepository.Delete(student);
            _logger.LogInformation($"Order {student.Id} is successfully deleted.");
            return Unit.Value;
        }
    
    }
}
