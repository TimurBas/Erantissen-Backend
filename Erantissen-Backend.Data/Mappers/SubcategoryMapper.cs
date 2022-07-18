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
                Products = subcategory.Products.Select(p => ProductMapper.MapDomainToDto(p, subcategory.Title)).ToList(),
                MostBoughtProducts = subcategory.MostBoughtProducts.Select(mbp => ProductMapper.MapDomainToMostBoughtDto(mbp, subcategory.Title)).ToList(),
                CategoryTitle = categoryTitle,
            };
        }

        public static void UpdateDtoFields(SubcategoryDto subcategoryDto, Subcategory subcategory)
        {
            subcategoryDto.ImageUrl = subcategory.ImageUrl;
        }
    }
}
