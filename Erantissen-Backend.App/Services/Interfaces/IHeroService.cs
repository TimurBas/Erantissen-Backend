using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Models.Requests.Update;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services.Interfaces
{
    public interface IHeroService
    {
        Task CreateHeroAsync(CreateHeroRequest r);
        Task UpdateHeroAsync(UpdateHeroRequest r);
        Task DeleteHeroAsync(int imageNumber);
    }
}
