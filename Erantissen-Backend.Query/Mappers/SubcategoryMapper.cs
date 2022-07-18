using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Query.Models;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Mappers
{
    public static class SubcategoryMapper
    {
        internal static SubcategoryReadDto MapDtoToReadDto(SubcategoryDto subcategory)
        {
            var subcategoryReadDto = new SubcategoryReadDto()
            {
                Title = subcategory.Title,
                ImageUrl = subcategory.ImageUrl,
                CategoryTitle = subcategory.CategoryTitle
            };

            if (subcategory.MostBoughtProducts is not null)
                subcategoryReadDto.MostBoughtProducts = ProductMapper.MapAllMostBought(subcategory.MostBoughtProducts);

            if (subcategory.Products is not null)
                subcategoryReadDto.Products = ProductMapper.MapAll(subcategory.Products);

            return subcategoryReadDto;
        }

        internal static List<SubcategoryReadDto> MapAll(List<SubcategoryDto> subcategories)
        {
            return subcategories.Select(sc => MapDtoToReadDto(sc)).ToList();
        }
    }
}
