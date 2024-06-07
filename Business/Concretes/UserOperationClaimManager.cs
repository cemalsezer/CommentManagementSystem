using Business.Abstracts;
using Business.Dtos.UserOperationClaim.Requests;
using Business.Dtos.UserOperationClaim.Responses;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        public Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            throw new NotImplementedException();
        }

        public Task<DeletedUserOperationClaimResponse> DeleteAsync(DeleteUserOperationClaimRequest deleteUserOperationClaimRequest)
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListUserOperationClaimResponse>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListUserOperationClaimResponse>> GetListByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
