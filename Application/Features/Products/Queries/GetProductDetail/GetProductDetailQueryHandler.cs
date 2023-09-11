using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.Posts.Queries.GetPostDetail
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, GetProductDetailViewModel>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductDetailQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<GetProductDetailViewModel> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var Product = await _productRepository.GetProductByIdAsync(request.ProductId, true);

            return _mapper.Map<GetProductDetailViewModel>(Product);
        }
    }
}
