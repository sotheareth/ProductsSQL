using Core.Entities;
using Core.Interfaces;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task AddProduct(Product product)
        {
            await this.productRepository.AddProduct(product);
        }

        public async Task DeleteProduct(int productId)
        {
            await this.productRepository.DeleteProduct(productId);
        }

        public Product GetProduct(int productId)
        {
            return this.productRepository.GetProduct(productId);
        }

        public async Task UpdateProduct(Product updateProduct)
        {
            await this.productRepository.UpdateProduct(updateProduct);
        }
    }
}
