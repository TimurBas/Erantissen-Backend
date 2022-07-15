using System.Collections.Generic;

namespace Erantissen_Backend.Query.Queries
{
    public interface IMostBoughtProductQuery
    {
        List<ProductReadDto> GetAll();
    }
}
