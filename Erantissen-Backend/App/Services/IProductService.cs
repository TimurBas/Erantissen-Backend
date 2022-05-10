using Erantissen_Backend.App.Models;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductRequest request);
        Task UpdateProduct(UpdateProductRequest request);
        Task DeleteProduct(string title);
    }
}
