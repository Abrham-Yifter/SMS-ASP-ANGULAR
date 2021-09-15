using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.StudentCQRS.Command.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly ILogger<CreateStudentCommand> _logger;
            private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IStudentRepository studentRepository, ILogger<CreateStudentCommand> logger, IMapper mapper)
            {
                _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
                _mapper = mapper;
            }
            public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
            {
                var student = _mapper.Map<Student>(request);
                var newOrder = await _studentRepository.AddAsync(student);
                _logger.LogInformation($"Student {newOrder.Id} is successfully created.");
                return newOrder.Id;
            }

  
    }
    }

