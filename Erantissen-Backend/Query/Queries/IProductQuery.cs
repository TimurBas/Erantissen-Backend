using System.Threading.Tasks;

namespace Erantissen_Backend.Query.Queries
{
    public interface IProductQuery
    {
        Task<ProductReadDto> GetProduct(string title);
    }
}
