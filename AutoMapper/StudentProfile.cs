using AutoMapper;
using AutoMapperr.Models;

namespace AutoMapperr
{
    public class StudentProfile:Profile 
    {
        public StudentProfile() 
        {
            CreateMap<Student, StudentVM>(); // Student classını StudentVM e map'le.

        }
    }
}
