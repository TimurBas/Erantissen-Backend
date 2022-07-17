using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Query.Mappers;
using Erantissen_Backend.Query.Models;
using Erantissen_Backend.Query.Queries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
        public HeroReadDto GetHero(int id)
        {
            var hero = _context.Hero.AsNoTracking().Where(h => h.Id == id).FirstOrDefault();
            var mappedHero = HeroMapper.MapDtoToReadDto(hero);
            return mappedHero;
        }

        public List<HeroReadDto> GetAll()
        {
            var heros = _context.Hero.AsNoTracking().ToList();
            var mappedHeros = HeroMapper.MapAll(heros);
            return mappedHeros;
        }
    }
}
