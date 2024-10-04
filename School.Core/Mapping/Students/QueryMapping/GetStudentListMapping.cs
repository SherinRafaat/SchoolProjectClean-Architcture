using School.Core.Feature.Students.Queries.Result;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.Students
{

   public partial class StudentProfile
    {
        public void GetStudentListMapping() 
        {
            CreateMap<Student, GetStudentListResponse>()
        .ForMember(desk => desk.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }    



    }
}
