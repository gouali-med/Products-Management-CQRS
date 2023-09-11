using MediatR;
using System;

namespace Application.Features.Posts.Commands.CreatePost
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
    }
}
