using Erantissen_Backend.Domain.Entities;
using System.Threading.Tasks;

namespace Erantissen_Backend.Domain.Repositories
{
    public interface IHeroRepository
    {
        Task AddHeroAsync(Hero hero);
        Task UpdateHeroAsync(int imageNumber, Hero hero);
        Task DeleteHeroAsync(int imageNumber);
    }
}
