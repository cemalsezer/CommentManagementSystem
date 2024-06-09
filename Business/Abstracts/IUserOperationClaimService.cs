using Business.Dtos.UserOperationClaim.Requests;
using Business.Dtos.UserOperationClaim.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IUserOperationClaimService
    {
        Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserAssignmentRequest createUserOperationClaimRequest);
        Task<Paginate<GetListUserOperationClaimResponse>> GetListAsync();
        Task<DeletedUserOperationClaimResponse> DeleteAsync(DeleteUserAssignmentRequest deleteUserOperationClaimRequest);
        Task<Paginate<GetListUserOperationClaimResponse>> GetListByUserIdAsync(Guid userId);
    }
}
