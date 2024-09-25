using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.infrastructure.Abstracts
{
   public interface IStudentRepository
    {
     public Task<List<Student>> GetStudents();

    }
}
