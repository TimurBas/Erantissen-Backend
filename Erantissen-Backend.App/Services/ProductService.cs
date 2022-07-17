using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Models.Requests.Update;
using Erantissen_Backend.App.Services.Interfaces;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateProduct(CreateProductRequest r)
        {
            var product = new Product(r.Title, r.Price, r.Description, r.Quantity, r.ImageUrl);
            await _repo.AddProductAsync(product);
        }
        public async Task UpdateProduct(UpdateProductRequest r)
        {
            await _repo.UpdateProductAsync(new Product(r.Title, r.Price, r.Description, r.Quantity, r.ImageUrl));
        }

        public async Task DeleteProduct(string title)
        {
            await _repo.DeleteProductAsync(title);
        }
    }
}
