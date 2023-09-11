using MediatR;
using System;

namespace Application.Features.Posts.Commands.DeletePost
{
    public class DeleteProductCommand : IRequest
    {
        public Guid ProductId { get; set; }
    }

}
