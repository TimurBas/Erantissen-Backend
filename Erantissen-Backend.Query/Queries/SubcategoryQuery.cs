using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Query.Mappers;
using Erantissen_Backend.Query.Models;
using Erantissen_Backend.Query.Queries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Queries
{
    public class SubcategoryQuery : ISubcategoryQuery
    {
        private readonly Context _context;
        public SubcategoryQuery(Context context)
        {
            _context = context;
        }

        public List<SubcategoryReadDto> GetAll()
        {
            var subcategories = _context.Subcategories
                .Include(sc => sc.Products)
                .AsNoTracking()
                .ToList();
            var mappedSubcategories = subcategories.Select(sc => SubcategoryMapper.MapDtoToReadDto(sc)).ToList();
            return mappedSubcategories;
        }

        public SubcategoryReadDto GetSubcategory(string title)
        {
            var subcategory = _context.Subcategories
                .Include(sc => sc.Products)
                .AsNoTracking()
                .Where(sc => sc.Title.Equals(title)).FirstOrDefault();
            var mappedSubcategory = SubcategoryMapper.MapDtoToReadDto(subcategory);
            return mappedSubcategory;
        }

        public List<SubcategoryReadDto> GetSubcategories(string categoryTitle)
        {
            var subcategories = _context.Subcategories
                .Include(sc => sc.Products)
                .AsNoTracking()
                .Where(sc => sc.CategoryTitle.Equals(categoryTitle)).ToList();
            var mappedSubcategories = subcategories.Select(sc => SubcategoryMapper.MapDtoToReadDto(sc)).ToList();
            return mappedSubcategories;
        }
    }
}
