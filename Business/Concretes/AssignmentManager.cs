using Business.Abstracts;
using Business.Dtos.Assignment.Requests;
using Business.Dtos.Assignment.Responses;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class AssignmentManager : IAssignmentService
    {
        public Task<CreatedAssignmentResponse> AddAsync(CreateAssignmentRequest createAssignmentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<DeletedAssignmentResponse> DeleteAsync(Guid assignmentId)
        {
            throw new NotImplementedException();
        }

        public Task<GetAssignmentResponse> GetByIdAsync(Guid assignmentId)
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListAssignmentResponse>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListAssignmentResponse>> GetListByUserIdAsync(Guid assignmentId)
        {
            throw new NotImplementedException();
        }
    }
}
