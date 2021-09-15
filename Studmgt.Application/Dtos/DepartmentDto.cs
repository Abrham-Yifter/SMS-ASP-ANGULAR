using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;

namespace Studmgt.Application.Dtos
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public string Location { get; set; }
    }
}
