using Microsoft.EntityFrameworkCore;
using School.Data.Models;
using School.infrastructure.Abstracts;
using School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.infrastructure.Repos
{
    public class StudentRepository:IStudentRepository
    {
        #region fileds

        private ApplicationDbContext _dbcontext;
        #endregion

        #region Constroctor
        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbcontext=dbContext;
        }
        #endregion

        #region functions
        public async Task<List<Student>> GetStudents()
        {
           return await _dbcontext.Students.ToListAsync();
        }
        #endregion










    }
}
