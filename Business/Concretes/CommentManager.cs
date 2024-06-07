using Business.Abstracts;
using Business.Dtos.Comment.Requests;
using Business.Dtos.Comment.Responses;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CommentManager : ICommentService
    {
        public Task<CreatedCommentResponse> AddAsync(CreateCommentRequest createCommentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<DeletedCommentResponse> DeleteAsync(Guid commentId)
        {
            throw new NotImplementedException();
        }

        public Task<GetCommentResponse> GetByIdAsync(Guid commentId)
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListCommentResponse>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<GetListCommentResponse>> GetListByUserIdAsync(Guid commentId)
        {
            throw new NotImplementedException();
        }
    }
}
