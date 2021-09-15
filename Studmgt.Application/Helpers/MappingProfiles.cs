
using AutoMapper;
using Studmgt.Domain.Model;
using Studmgt.Application.Dtos;
using System.Linq;

namespace Studmgt.Application.Helpers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Student, StudentDto>().ReverseMap(); 
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Enrollment, EnrollmentDto>().ReverseMap();
        }
    }
}
