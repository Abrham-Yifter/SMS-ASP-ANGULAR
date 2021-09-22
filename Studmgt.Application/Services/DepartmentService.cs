using AutoMapper;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Dtos;
using Studmgt.Application.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Linq;
using LinqKit;
using System.Threading.Tasks;

namespace Studmgt.Application.Services
{
    public class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository; 
        private readonly ILogger<DepartmentService> _logger;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository departmentRepository, ILogger<DepartmentService> logger, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;
            _mapper = mapper;
        }

        async Task<ResponseDto<DepartmentDto>> IDepartmentService.Create(DepartmentDto member)
        {
            return new ResponseDto<DepartmentDto>(_mapper.Map<DepartmentDto>(await _departmentRepository.AddAsync(_mapper.Map<Department>(member))), true, "Member Created Successfully");
        }

        ResponseDto<DepartmentDto> IDepartmentService.Update(DepartmentDto member)
        {
            return new ResponseDto<DepartmentDto>(member, _departmentRepository.Update(_mapper.Map<Department>(member)), "Member Updated Successfully");
        }

        ResponseDto<DepartmentDto> IDepartmentService.Delete(int id)
        {
            return new ResponseDto<DepartmentDto>(_departmentRepository.Delete(id), "Member Deleted Successfully");
        }

        [Obsolete]
        public async Task<ResponseDto<DepartmentDto>> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize)
        {
            var predicate = PredicateBuilder.True<Department>();
            if (id != null)
                predicate = predicate.And(p => p.Id == id);
            else
                predicate = string.IsNullOrEmpty(searchKey) ? null
                           : predicate.And
                            (
                                p => p.DepartmentName.Contains(searchKey) ||
                                p.Location.Contains(searchKey) ||
                                p.DepartmentDescription.Contains(searchKey)
                            );
            return new ResponseDto<DepartmentDto>
                (
                    (await _departmentRepository.GetWithPredicateAsync(predicate, pageIndex ?? 0, pageSize ?? 2))
                    .Select(x => _mapper.Map<DepartmentDto>(x)
                    ).ToList()
                );
        }

        async Task<ResponseDto<DepartmentDto>> IDepartmentService.GetById(int id)
        {
            return new ResponseDto<DepartmentDto>(_mapper.Map<DepartmentDto>(await _departmentRepository.GetByIdAsync(id)));
        }

        async Task<ResponseDto<DepartmentDto>> IDepartmentService.GetAll()
        {
            return new ResponseDto<DepartmentDto>((await _departmentRepository.GetAllAsync()).Select(x => _mapper.Map<DepartmentDto>(x)).ToList());
        }


    }
}
