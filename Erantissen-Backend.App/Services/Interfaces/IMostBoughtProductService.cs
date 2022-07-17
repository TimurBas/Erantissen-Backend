using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Models.Requests.Update;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services.Interfaces
{
    public interface IMostBoughtProductService
    {
        Task CreateProduct(CreateProductRequest r);
        Task UpdateProduct(UpdateProductRequest r);
        Task DeleteProduct(string title);
    }
}
