using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Data.Mappers;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Erantissen_Backend.Data.Repositories
{
    public class HeroRepository : IHeroRepository
    {
        private readonly Context _context;

        public HeroRepository(Context context)
        {
            _context = context;
        }

        public async Task AddHeroAsync(Hero hero)
        {
            var mappedHero = HeroMapper.MapDomainToDto(hero);
            await _context.Hero.AddAsync(mappedHero);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHeroAsync(int imageNumber, Hero hero)
        {
            var heroDto = _context.Hero.Where(h => h.ImageNumber == imageNumber).FirstOrDefault();
            HeroMapper.UpdateDtoFields(heroDto, hero);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHeroAsync(int imageNumber)
        {
            var hero = _context.Hero.Where(h => h.ImageNumber == imageNumber).FirstOrDefault();
            _context.Hero.Remove(hero);
            await _context.SaveChangesAsync();
        }
    }
}
