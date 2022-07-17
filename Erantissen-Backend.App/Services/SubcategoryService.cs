using Erantissen_Backend.App.Mappers;
using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Models.Requests.Update;
using Erantissen_Backend.App.Services.Interfaces;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public class SubcategoryService : ISubcategoryService
    {
        private readonly ISubcategoryRepository _repo;
        public SubcategoryService(ISubcategoryRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateSubcategoryAsync(CreateSubcategoryRequest r)
        {
            var subcategory = new Subcategory(r.Title, r.ImageUrl, ProductMapper.MapProducts(r.Products), ProductMapper.MapProducts(r.MostBoughtProducts));
            await _repo.AddSubcategoryAsync(subcategory);
        }
        public async Task UpdateSubcategoryAsync(string title, UpdateSubcategoryRequest r)
        {
            var subcategory = new Subcategory(title, r.ImageUrl);
            await _repo.UpdateSubcategoryAsync(subcategory);
        }
        public async Task DeleteSubcategoryAsync(string title)
        {
            await _repo.DeleteSubcategoryAsync(title);
        }
    }
}
