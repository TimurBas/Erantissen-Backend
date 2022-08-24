using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Data.Mappers;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Erantissen_Backend.Data.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public async Task AddCategoryAsync(Category category)
        {
            var mappedCategory = CategoryMapper.MapDomainToDto(category);
            await _context.Categories.AddAsync(mappedCategory);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateCategoryAsync(Category category)
        {
            var categoryDto = _context.Categories.Where(c => c.Title.Equals(category.Title)).FirstOrDefault();
            CategoryMapper.UpdateDtoFields(categoryDto, category);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCategoryAsync(string title)
        {
            var category = _context.Categories
                .Include(c => c.Subcategories)
                    .ThenInclude(sc => sc.Products)
                .FirstOrDefault();
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
