using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Services.Abstracts
{
    public interface IStudentServices
    {
        public Task<List<Student>> GetStudentsListAsync();

    }
}
