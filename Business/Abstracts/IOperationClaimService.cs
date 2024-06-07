using Business.Dtos.OperationClaim.Requests;
using Business.Dtos.OperationClaim.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IOperationClaimService
    {
        Task<CreatedOperationClaimResponse> AddAsync(CreateOperationClaimRequest createOperationClaimRequest);
        Task<Paginate<GetListOperationClaimResponse>> GetListAsync();
        Task<DeletedOperationClaimResponse> DeleteAsync(Guid operationClaimId);
        Task<UpdatedOperationClaimResponse> UpdateAsync(UpdateOperationClaimRequest updateOperationClaimRequest);
        Task<GetOperationClaimResponse> GetAsync(Guid operationClaimId);
    }
}
