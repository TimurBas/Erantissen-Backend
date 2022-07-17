using Erantissen_Backend.Query.Models;
using System.Collections.Generic;

namespace Erantissen_Backend.Query.Queries.Interfaces
{
    public interface IHeroQuery
    {
        HeroReadDto GetHero(int imageNumber);
        List<HeroReadDto> GetAll();
    }
}
