
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;

namespace Application.Features.Posts.Commands.DeletePost
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.ProductId);

            await _productRepository.DeleteAsync(product);

            return Unit.Value;
        }
    }

}
