using Application.Features.Posts.Commands.CreatePost;
using Application.Features.Posts.Commands.DeletePost;
using Application.Features.Posts.Commands.UpdatePost;
using Application.Features.Posts.Queries.GetPostDetail;
using AutoMapper;
using Domain;
using PostLand.Application.Features.Posts.Queries.GetPostsList;

namespace Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductsListViewModel>().ReverseMap();
            CreateMap<Product, GetProductDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Product, DeleteProductCommand>().ReverseMap();
        }
    }
}
