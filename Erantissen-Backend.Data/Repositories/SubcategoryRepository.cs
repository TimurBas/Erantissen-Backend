using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Data.Mappers;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Erantissen_Backend.Data.Repositories
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        private readonly Context _context;
        public SubcategoryRepository(Context context)
        {
            _context = context;
        }
        public async Task AddSubcategoryAsync(Subcategory subcategory, string categoryTitle)
        {
            var category = _context.Categories.Find(categoryTitle);

            if (category is null)
                return;

            var mappedSubcategory = SubcategoryMapper.MapDomainToDto(subcategory, categoryTitle);

            await _context.Subcategories.AddAsync(mappedSubcategory);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSubcategoryAsync(Subcategory subcategory)
        {
            var subcategoryDto = _context.Subcategories.Where(c => c.Title.Equals(subcategory.Title)).FirstOrDefault();
            SubcategoryMapper.UpdateDtoFields(subcategoryDto, subcategory);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteSubcategoryAsync(string title)
        {
            var subcategory = _context.Subcategories.Include(sc => sc.Products).Include(sc => sc.MostBoughtProducts).Where(sc => sc.Title.Equals(title)).FirstOrDefault();
            _context.Subcategories.Remove(subcategory);
            await _context.SaveChangesAsync();
        }
    }
}
