using AutoMapper;

using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Application.Features.Posts.Commands.UpdatePost;
using Application.Contracts.Persistence;

namespace Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IAsyncRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            Product Product = _mapper.Map<Product>(request);

            await _productRepository.UpdateAsync(Product);

            return Unit.Value;
        }
    }
}
