using Erantissen_Backend.Query.Models;
using System.Collections.Generic;

namespace Erantissen_Backend.Query.Queries.Interfaces
{
    public interface IMostBoughtProductQuery
    {
        List<ProductReadDto> GetAll();
    }
}
