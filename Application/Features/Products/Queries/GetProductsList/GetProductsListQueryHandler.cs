using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace PostLand.Application.Features.Posts.Queries.GetPostsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<GetProductsListViewModel>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<List<GetProductsListViewModel>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var allProducts = await _productRepository.GetAllProductsAsync(true);
            return _mapper.Map<List<GetProductsListViewModel>>(allProducts);
        }
    }
}
