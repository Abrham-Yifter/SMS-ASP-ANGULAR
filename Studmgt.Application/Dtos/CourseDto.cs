
using System;

namespace Studmgt.Application.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public int DepartmentId { get; set; }
    }
}
