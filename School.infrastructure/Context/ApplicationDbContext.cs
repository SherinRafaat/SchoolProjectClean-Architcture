using Microsoft.EntityFrameworkCore;
using School.Data.Models;

namespace School.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; } 
        public DbSet<Department> Departments { get; set; }
        public  DbSet<Subjects> Subjects { get; set; }  
        public DbSet<DepartmentSubject> DepartmentSubjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }





    }
}
