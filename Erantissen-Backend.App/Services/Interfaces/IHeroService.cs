using Erantissen_Backend.App.Models;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public interface IHeroService
    {
        Task CreateHeroAsync(CreateHeroRequest r);
        Task UpdateHeroAsync(UpdateHeroRequest r);
        Task DeleteHeroAsync(int imageNumber);
    }
}
