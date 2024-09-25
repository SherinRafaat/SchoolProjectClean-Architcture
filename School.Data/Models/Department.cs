using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace School.Data.Models
{
    public class Department
    {
    public Department() 
        {
            Students=new HashSet<Student>();
            DepartmentSubjects = new HashSet<DepartmentSubject>();
        }

        [Key]
        public int DId { get; set; }

        [StringLength(100)]
        public string DName { get; set; }
        [StringLength(500)]
      
        public virtual ICollection<Student>  Students{ get; set; }
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }


    }
}
