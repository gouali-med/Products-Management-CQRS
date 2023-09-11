using MediatR;
using System;

namespace Application.Features.Posts.Queries.GetPostDetail
{
    public class GetProductDetailQuery : IRequest<GetProductDetailViewModel>
    {
        public Guid ProductId { get; set; }
    }
}
