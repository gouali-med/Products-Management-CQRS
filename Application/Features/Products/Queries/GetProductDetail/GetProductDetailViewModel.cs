using PostLand.Application.Features.Posts.Queries.GetPostsList;
using System;

namespace Application.Features.Posts.Queries.GetPostDetail
{
    public class GetProductDetailViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
    }
}
