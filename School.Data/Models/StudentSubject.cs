using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Models
{
    public class StudentSubject
    {
        [Key]
        public int StuSubId { get; set; } 
        public int StuId { get; set; }
        public int SubId { get; set; }

        [ForeignKey("StuId")]
        public virtual Student Student { get; set; }
        [ForeignKey("SubId")]
        public virtual Subjects Subject { get; set; }

    }
}
