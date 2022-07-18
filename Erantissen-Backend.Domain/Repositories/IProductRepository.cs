using Erantissen_Backend.Domain.Entities;
using System.Threading.Tasks;

namespace Erantissen_Backend.Domain.Repositories
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product, string subcategoryTitle);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(string title);
    }
}
