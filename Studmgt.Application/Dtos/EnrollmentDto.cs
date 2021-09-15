using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studmgt.Application.Dtos
{
    public class EnrollmentDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
