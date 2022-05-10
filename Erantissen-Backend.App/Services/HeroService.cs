using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _repo;

        public HeroService(IHeroRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateHeroAsync(CreateHeroRequest r)
        {
            await _repo.AddHeroAsync(new Hero(r.Heading, r.Paragraph, r.ButtonText, r.DiscountText));
        }
    }
}
