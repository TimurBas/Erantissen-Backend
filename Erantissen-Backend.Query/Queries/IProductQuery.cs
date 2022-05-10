using System.Threading.Tasks;

namespace Erantissen_Backend.Query.Queries
{
    public interface IProductQuery
    {
        ProductReadDto GetProduct(string title);
    }
}
