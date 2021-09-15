using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studmgt.Application.Dtos;
using Studmgt.Application.Interfaces.Facade;
using System;
using System.Threading.Tasks;

namespace RestAPICompleted.Controllers
{
    public class CoursesController : BaseApiController
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService departmentService)
        {
            _courseService = departmentService;
        }

        [HttpGet]
        public async Task<ResponseDto<CourseDto>> Get(int id)
        {
            return await _courseService.GetById(id);
        }
        [HttpGet("GetAllCourses")]
        public async Task<ResponseDto<CourseDto>> GetAllCourses()
        {
            return await _courseService.GetAll();
        }
        [HttpPost]
        public async Task<ResponseDto<CourseDto>> Add(CourseDto course)
        {
            return await _courseService.Create(course);
        }
        [HttpPut]
        public ResponseDto<CourseDto> Edit(CourseDto course)
        {
            return _courseService.Update(course);
        }
        [HttpDelete]
        public ResponseDto<CourseDto> Remove(int id)
        {
            return _courseService.Delete(id);
        }
    }
}
