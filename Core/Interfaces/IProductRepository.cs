using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task AddProduct(Product product);

        Task UpdateProduct(Product updateProduct);

        Task DeleteProduct(int productId);

        Product GetProduct(int productId);
    }
}
