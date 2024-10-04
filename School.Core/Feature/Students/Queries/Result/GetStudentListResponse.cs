using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Feature.Students.Queries.Result
{
    public class GetStudentListResponse
    {
        public int StuId { get; set; }
        public string ? StuName { get; set; }
        public string ? Address { get; set; }
        public string ? DepartmentName { get; set; }



    }
}
