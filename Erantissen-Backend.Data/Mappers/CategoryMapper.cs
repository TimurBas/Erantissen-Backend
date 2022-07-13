using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Domain.Entities;
using System.Linq;

namespace Erantissen_Backend.Data.Mappers
{
    public class CategoryMapper
    {
        internal static CategoryDto MapDomainToDto(Category category)
        {
            return new CategoryDto()
            {
                Title = category.Title,
                Description = category.Description,
                Subcategories = category.Subcategories.Select(s => MapDomainToDto(s)).ToList()
            };
        }

        internal static void UpdateDtoFields(CategoryDto categoryDto, Category category)
        {
            categoryDto.Title = category.Title;
            categoryDto.Description = category.Description;
            categoryDto.Subcategories = category.Subcategories.Select(s => MapDomainToDto(s)).ToList();
        }

        private static SubcategoryDto MapDomainToDto(Subcategory subcategory)
        {
            return new SubcategoryDto()
            {
                Title = subcategory.Title
            };
        }
    }
}
