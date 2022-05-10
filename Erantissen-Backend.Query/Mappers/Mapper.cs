using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Query.Models;
using System;

namespace Erantissen_Backend.Query.Mappers
{
    public static class Mapper
    {
        internal static ProductReadDto MapProductDtoToReadDto(ProductDto product)
        {
            return new ProductReadDto()
            {
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity,
                ImageUrl = product.ImageUrl,
                Tag = product.Tag
            };
        }

        internal static HeroReadDto MapHeroDtoToReadDto(HeroDto hero)
        {
            return new HeroReadDto()
            {
                ImageNumber = hero.ImageNumber,
                Heading = hero.Heading,
                Paragraph = hero.Paragraph,
                ButtonText = hero.ButtonText,
                DiscountText = hero.DiscountText
            };
        }
    }
}
