using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studmgt.Application.Dtos;
using Studmgt.Domain.Interfaces.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICompleted.Controllers
{

    public class StudentsController : BaseApiController
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ResponseDto<StudentDto>> Get(int id)
        {
            return await _studentService.GetById(id);
        }
        [HttpGet("GetAllStudents")]
        public async Task<ResponseDto<StudentDto>> GetAllDepatments()
        {
            return await _studentService.GetAll();
        }
        [HttpPost]
        public async Task<ResponseDto<StudentDto>> Add(StudentDto member)
        {
            return await _studentService.Create(member);
        }
        [HttpPut]
        public ResponseDto<StudentDto> Edit(StudentDto member)
        {
            return _studentService.Update(member);
        }
        [HttpDelete]
        public ResponseDto<StudentDto> Remove(int id)
        {
            return _studentService.Delete(id);
        }
    }
}
