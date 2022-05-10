using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Query.Mappers;
using Erantissen_Backend.Query.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Erantissen_Backend.Query.Queries
{
    public class HeroQuery : IHeroQuery
    {
        private readonly Context _context;
        public HeroQuery(Context context)
        {
            _context = context;
        }
        public HeroReadDto GetHero(int imageNumber)
        {
            var hero = _context.Hero.AsNoTracking().Where(h => h.ImageNumber == imageNumber).FirstOrDefault();
            var mappedHero = Mapper.MapHeroDtoToReadDto(hero);
            return mappedHero;
        }
    }
}
