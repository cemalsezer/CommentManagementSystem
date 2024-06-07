using Business.Dtos.Assignment.Requests;
using Business.Dtos.Assignment.Responses;
using Business.Dtos.User.Responses;
using Business.Dtos.UserOperationClaim.Requests;
using Business.Dtos.UserOperationClaim.Responses;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IAssignmentService
    {
        Task<CreatedAssignmentResponse> AddAsync(CreateAssignmentRequest createAssignmentRequest);
        Task<Paginate<GetListAssignmentResponse>> GetListAsync();
        Task<DeletedAssignmentResponse> DeleteAsync(Guid  assignmentId);
        Task<Paginate<GetListAssignmentResponse>> GetListByUserIdAsync(Guid assignmentId);
        Task<GetAssignmentResponse> GetByIdAsync(Guid assignmentId);
    }
}
