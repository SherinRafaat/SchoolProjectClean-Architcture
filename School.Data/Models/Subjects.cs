using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Data.Models
{
    public class Subjects
    {
        public Subjects()
        {
            StudentSubjects = new HashSet<StudentSubject>();
           DepartmentSubjects = new HashSet<DepartmentSubject>();
        }

        [Key]
        public int SubId { get; set; }
        [StringLength(100)]
        public string SubName { get; set; }
        [StringLength(500)]
        public DateTime Period { get; set; }    

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }

    }

}

