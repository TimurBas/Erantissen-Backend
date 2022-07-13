using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Query.Mappers;
using Erantissen_Backend.Query.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Queries
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly Context _context;
        public CategoryQuery(Context context)
        {
            _context = context;
        }

        public List<CategoryReadDto> GetAll()
        {
            var categories = _context.Categories.AsNoTracking().ToList();
            var mappedCategories = CategoryMapper.MapAll(categories);
            return mappedCategories;
        }

        public CategoryReadDto GetCategory(string title)
        {
            var category = _context.Categories.AsNoTracking().Where(c => c.Title.Equals(title)).FirstOrDefault();
            var mappedCategory = CategoryMapper.MapDtoToReadDto(category);
            return mappedCategory;
        }
    }
}
