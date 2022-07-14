using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }
        public async Task CreateCategoryAsync(CreateCategoryRequest r)
        {
            var subcategories = r.Subcategories.Select(sc => new Subcategory(sc.Title, sc.ImageUrl, sc.Products.Select(p => new Product(p.Title, p.Price, p.Description, p.Quantity, p.ImageUrl)).ToList())).ToList();
            var category = new Category(r.Title, r.Description, subcategories);
            await _repo.AddCategoryAsync(category);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryRequest r)
        {
            var subcategories = r.Subcategories.Select(sc => new Subcategory(sc.Title, sc.ImageUrl, sc.Products.Select(p => new Product(p.Title, p.Price, p.Description, p.Quantity, p.ImageUrl)).ToList())).ToList();
            var category = new Category(r.Title, r.Description, subcategories);
            await _repo.UpdateCategoryAsync(r.Title, category);
        }

        public async Task DeleteCategoryAsync(string title)
        {
            await _repo.DeleteCategoryAsync(title);
        }
    }
}
