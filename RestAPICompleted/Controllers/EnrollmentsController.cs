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

    public class EnrollmentsController : BaseApiController
    {
        private readonly IEnrollmentService _enrollmentService;
        public EnrollmentsController(IEnrollmentService EnrollmentService)
        {
            _enrollmentService = EnrollmentService;
        }

        [HttpGet]
        public async Task<ResponseDto<EnrollmentDto>> Get(int id)
        {
            return await _enrollmentService.GetById(id);
        }
        [HttpGet("GetAllEnrollments")]
        public async Task<ResponseDto<EnrollmentDto>> GetAllDepatments()
        {
            return await _enrollmentService.GetAll();
        }
        [HttpPost]
        public async Task<ResponseDto<EnrollmentDto>> Add(EnrollmentDto member)
        {
            return await _enrollmentService.Create(member);
        }
        [HttpPut]
        public ResponseDto<EnrollmentDto> Edit(EnrollmentDto member)
        {
            return _enrollmentService.Update(member);
        }
        [HttpDelete]
        public ResponseDto<EnrollmentDto> Remove(int id)
        {
            return _enrollmentService.Delete(id);
        }
    }
}
