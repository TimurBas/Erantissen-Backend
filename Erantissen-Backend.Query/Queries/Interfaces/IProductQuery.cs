using System.Collections.Generic;

namespace Erantissen_Backend.Query.Queries
{
    public interface IProductQuery
    {
        ProductReadDto GetProduct(string title);
        List<ProductReadDto> GetAll();
    }
}
