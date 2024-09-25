using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Models
{
    public class DepartmentSubject
    {
        [Key]
        public int DepSubId { get; set; }
        public int DId { get; set; }
        public int SubId { get; set; }

        [ForeignKey("DId")]
        public virtual Department Department { get; set; }
        [ForeignKey("SubId")]
        public virtual Subjects Subjects { get; set; }





    }
}
