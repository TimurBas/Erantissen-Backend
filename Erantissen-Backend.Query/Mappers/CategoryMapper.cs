using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Query.Models;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Mappers
{
    public static class CategoryMapper
    {
        internal static CategoryReadDto MapDtoToReadDto(CategoryDto category)
        {
            return new CategoryReadDto()
            {
               Title = category.Title,
               Description = category.Description,
               Subcategories = category.Subcategories.Select(s => MapDomainToDto(s)).ToList()
            };
        }

        internal static List<CategoryReadDto> MapAll(List<CategoryDto> categories)
        {
            return categories.Select(c => MapDtoToReadDto(c)).ToList();
        }

        private static SubcategoryReadDto MapDomainToDto(SubcategoryDto subcategory)
        {
            return new SubcategoryReadDto()
            {
                Title = subcategory.Title
            };
        }
    }
}
