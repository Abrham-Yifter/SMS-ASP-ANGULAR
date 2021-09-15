using AutoMapper;
using Studmgt.Application.Dtos;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.StudentCQRS.Queries.GetStudentList
{
   public  class GetStudentListQueryHandler
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public GetStudentListQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
            _mapper = mapper;
        }
        public async Task<List<StudentDto>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _studentRepository.GetStudentByUserName(request.Name);
            return studentList?.Select(o => _mapper.Map<StudentDto>(o)).ToList();

        }
    }

}

