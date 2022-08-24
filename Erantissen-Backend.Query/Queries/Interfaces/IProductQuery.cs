using Erantissen_Backend.Query.Models;
using System.Collections.Generic;

namespace Erantissen_Backend.Query.Queries.Interfaces
{
    public interface IProductQuery
    {
        ProductReadDto GetProduct(string title);
        List<ProductReadDto> GetAll();
        List<ProductReadDto> GetMostBoughtProducts();
    }
}
