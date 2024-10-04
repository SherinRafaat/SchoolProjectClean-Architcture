using MediatR;
using School.Core.Bases;
using School.Core.Feature.Students.Queries.Result;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Feature.Students.Queries.Models
{
    public class GetStudentListQuery:IRequest<Response< List<GetStudentListResponse>>>
    {


    }
}
