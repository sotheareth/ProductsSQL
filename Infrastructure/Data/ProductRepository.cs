using Core.Entities;
using Core.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task AddProduct(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == productId);
            _context.Remove(product);
            await _context.SaveChangesAsync();
        }

        public Product GetProduct(int productId)
        {
            return _context.Products.FirstOrDefault(x => x.ProductId == productId);
        }

        public async Task UpdateProduct(Product updateProduct)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == updateProduct.ProductId);
            product.ProductName = updateProduct.ProductName;
            product.Description = updateProduct.Description;
            product.Price = updateProduct.Price;
            await _context.SaveChangesAsync();
        }
    }
}
