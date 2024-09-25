using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Models
{
public class Student
{ 


 [Key]
public int StuId { get; set; }
[StringLength(100)]
public string StuName { get; set; }
  [StringLength(500)] 
public string Address { get; set; }
  [StringLength(500)] 
public int Phone { get; set; }

 [ForeignKey("DId")]
 public virtual Department Department { get; set; }



    }
}
