using Business.Abstracts;
using Business.Dtos.OperationClaim.Requests;
using Business.Dtos.OperationClaim.Responses;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class OperationClaimManager : IOperationClaimService
    {
        public Task<CreatedOperationClaimResponse> AddAsync(CreateOperationClaimRequest createOperationClaimRequest)
        {
            throw new NotImplementedException();
        }

        public Task<DeletedOperationClaimResponse> DeleteAsync(Guid operationClaimId)
        {
            throw new NotImplementedException();
        }

        public Task<GetOperationClaimResponse> GetByIdAsync(Guid operationClaimId)
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListOperationClaimResponse>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdatedOperationClaimResponse> UpdateAsync(UpdateOperationClaimRequest updateOperationClaimRequest)
        {
            throw new NotImplementedException();
        }
    }
}
