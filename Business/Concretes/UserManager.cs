using Business.Abstracts;
using Business.Dtos.User.Requests;
using Business.Dtos.User.Responses;
using Core.DataAccess.Paging;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        public Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<DeletedUserResponse> DeleteAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdUserResponse> GetByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<IOperationClaim> GetClaims(IUser user)
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListUserResponse>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest)
        {
            throw new NotImplementedException();
        }
    }
}
