using AutoMapper;
using MediatR;
using School.Core.Bases;
using School.Core.Feature.Students.Queries.Models;
using School.Core.Feature.Students.Queries.Result;
using School.Data.Models;
using School.Services.Abstracts;

namespace School.Core.Feature.Students.Queries.Handler
{
    public class StudentHandler :ResponseHandler, IRequestHandler<GetStudentListQuery,Response<List<GetStudentListResponse>>>

    {
        #region Field
        private readonly IStudentServices _studentServices;
        private readonly IMapper _mapper;
        #endregion


        #region Constructor
        public StudentHandler(IStudentServices studentServices,IMapper mapper) 
        {
            _studentServices = studentServices;
            _mapper = mapper;
        }
        #endregion

        #region Functions
        public async Task<Response< List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
           var studentList= await _studentServices.GetStudentsListAsync();  
           var studentmapper= _mapper.Map<List<GetStudentListResponse>>(studentList);
            return Success( studentmapper);
        }
        #endregion
    }

}
