using Erantissen_Backend.Query.Models;

namespace Erantissen_Backend.Query.Queries
{
    public interface IHeroQuery
    {
        HeroReadDto GetHero(int imageNumber);
    }
}
