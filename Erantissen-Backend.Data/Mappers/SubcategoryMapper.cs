using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Domain.Entities;
using System.Linq;

namespace Erantissen_Backend.Data.Mappers
{
    public static class SubcategoryMapper
    {
        public static SubcategoryDto MapDomainToDto(Subcategory subcategory, string categoryTitle)
        {
            return new SubcategoryDto()
            {
                Title = subcategory.Title,
                ImageUrl = subcategory.ImageUrl,
                CategoryTitle = categoryTitle,
            };
        }

        public static void UpdateDtoFields(SubcategoryDto subcategoryDto, Subcategory subcategory)
        {
            subcategoryDto.ImageUrl = subcategory.ImageUrl;
        }
    }
}
