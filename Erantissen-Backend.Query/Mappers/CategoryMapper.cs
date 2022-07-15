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
            var categoryReadDto = new CategoryReadDto()
            {
                Title = category.Title,
                Description = category.Description
            };

            if (category.Subcategories is null)
                return categoryReadDto;

            categoryReadDto.Subcategories = category.Subcategories.Select(s => MapDomainToDto(s)).ToList();

            return categoryReadDto;
        }

        internal static List<CategoryReadDto> MapAll(List<CategoryDto> categories)
        {
            return categories.Select(c => MapDtoToReadDto(c)).ToList();
        }

        private static SubcategoryReadDto MapDomainToDto(SubcategoryDto subcategory)
        {
            var subcategoryReadDto = new SubcategoryReadDto()
            {
                Title = subcategory.Title,
                ImageUrl = subcategory.ImageUrl
            };

            if (subcategory.MostBoughtProducts is not null)
                subcategoryReadDto.MostBoughtProducts = ProductMapper.MapAllMostBought(subcategory.MostBoughtProducts);

            if (subcategory.Products is not null)
                subcategoryReadDto.Products = ProductMapper.MapAll(subcategory.Products);

            return subcategoryReadDto;
        }
    }
}
