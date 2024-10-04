using School.Data.Models;
using School.infrastructure.Abstracts;
using School.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Services.Implementations
{
    public class StudentServices : IStudentServices
    {
        #region fileds
        private readonly IStudentRepository _studentRepository;
        #endregion

        #region Constroctor
        public StudentServices(IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository;
        }
        #endregion

         #region handle functions
        public async Task<List<Student>> GetStudentsListAsync()
        {
          return  await _studentRepository.GetStudentsAsync();
        }
        #endregion



    }
}
