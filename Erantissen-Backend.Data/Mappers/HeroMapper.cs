using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Domain.Entities;

namespace Erantissen_Backend.Data.Mappers
{
    public static class HeroMapper
    {
        internal static HeroDto MapDomainToDto(Hero hero)
        {
            return new HeroDto()
            {
                ImageUrl = hero.ImageUrl,
                Heading = hero.Heading,
                Paragraph = hero.Paragraph,
                ButtonText = hero.ButtonText,
                DiscountText = hero.DiscountText,
                DiscountAmount = hero.DiscountAmount
            };
        }

        internal static void UpdateDtoFields(HeroDto heroDto, Hero hero)
        {
            heroDto.ImageUrl = hero.ImageUrl;
            heroDto.Heading = hero.Heading;
            heroDto.Paragraph = hero.Paragraph;
            heroDto.ButtonText = hero.ButtonText;
            heroDto.DiscountText = hero.DiscountText;
        }
    }
}
