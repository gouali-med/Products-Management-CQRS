
using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync(bool includeCategory);
        Task<Product> GetProductByIdAsync(Guid id, bool includeCategory);
    }
}
