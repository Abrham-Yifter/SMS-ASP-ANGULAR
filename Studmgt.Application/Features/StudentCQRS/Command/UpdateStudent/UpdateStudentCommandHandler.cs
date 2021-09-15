using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;

using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.StudentCQRS.Command.UpdateStudent
{
   
        //public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
        //{
        //    private readonly IStudentRepository _studentRepository;
        //    private readonly ILogger<UpdateStudentCommand> _logger;
        //    private readonly IMapper _mapper;

        //public UpdateStudentCommandHandler(IStudentRepository studentRepository, ILogger<UpdateStudentCommand> logger, IMapper mapper)
        //    {
        //        _studentRepository = studentRepository;
        //        _logger = logger;
        //        _mapper = mapper;
        //    }
        //    public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        //    {

        //        var studentToUpdate = await _studentRepository.GetByIdAsync(request.Id);
        //        if (studentToUpdate == null)
        //        {
        //            throw new NotFoundException(nameof(Student), request.int);
        //        }
        //        var model = _mapper.Map<Student>(request);
        //        //await _studentRepository.Update(model);
        //        _logger.LogInformation($"Order {studentToUpdate.int} is successfully updated.");
        //        return Unit.Value;

        //    }
        //}


    }
