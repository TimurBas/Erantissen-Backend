using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Query.Models;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Mappers
{
    public static class HeroMapper
    {
        internal static HeroReadDto MapDtoToReadDto(HeroDto hero)
        {
            return new HeroReadDto()
            {
                Id = hero.Id,
                ImageUrl = hero.ImageUrl,
                Heading = hero.Heading,
                Paragraph = hero.Paragraph,
                ButtonText = hero.ButtonText,
                DiscountText = hero.DiscountText,
                Discount = hero.Discount
            };
        }

        internal static List<HeroReadDto> MapAll(List<HeroDto> heros)
        {
            return heros.Select(h => MapDtoToReadDto(h)).ToList();
        }
    }
}
