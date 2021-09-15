using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studmgt.Application.Dtos;
using Studmgt.Application.Interfaces.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICompleted.Controllers
{

    public class DepartmentsController : BaseApiController
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<ResponseDto<DepartmentDto>> Get(int id)
        {
            return await _departmentService.GetById(id);
        }
        [HttpGet("GetAllDepartments")]
        public async Task<ResponseDto<DepartmentDto>> GetAllDepatments()
        {
            return await _departmentService.GetAll();
        }
        [HttpPost]
        public async Task<ResponseDto<DepartmentDto>> Add(DepartmentDto member)
        {
            return await _departmentService.Create(member);
        }
        [HttpPut]
        public ResponseDto<DepartmentDto> Edit(DepartmentDto member)
        {
            return _departmentService.Update(member);
        }
        [HttpDelete]
        public ResponseDto<DepartmentDto> Remove(int id)
        {
            return _departmentService.Delete(id);
        }
    }
}
