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
            var hero = new Hero(r.ImageUrl, r.Heading, r.Paragraph, r.ButtonText, r.DiscountText, r.Discount);
            await _repo.AddHeroAsync(hero);
        }

        public async Task UpdateHeroAsync(UpdateHeroRequest r)
        {
            var hero = new Hero(r.ImageUrl, r.Heading, r.Paragraph, r.ButtonText, r.DiscountText, r.Discount);
            await _repo.UpdateHeroAsync(r.ImageNumber, hero);
        }

        public async Task DeleteHeroAsync(int imageNumber)
        {
            await _repo.DeleteHeroAsync(imageNumber);
        }
    }
}
