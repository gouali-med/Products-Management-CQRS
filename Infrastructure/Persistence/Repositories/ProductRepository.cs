
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using Domain;

namespace Persistence
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductsDbContext productDbContext): base(productDbContext)
        {

        }
        public async Task<IReadOnlyList<Product>> GetAllProductsAsync(bool includeCategory)
        {
            List<Product> allProducts = new List<Product>();
            allProducts = includeCategory ? await _dbContext.Products.Include(x => x.Categorie).ToListAsync() : await _dbContext.Products.ToListAsync();
            return allProducts;
        }

        public async Task<Product> GetProductByIdAsync(Guid id, bool includeCategory)
        {
            Product Product = new Product();
            Product = includeCategory ? await _dbContext.Products.Include(x => x.Categorie).FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);
            return Product;
        }
    }

}
