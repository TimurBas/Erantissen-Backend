using Erantissen_Backend.Data.Contexts;
using System.Threading.Tasks;

namespace Erantissen_Backend.Query.Queries
{
    public class ProductQuery : IProductQuery
    {
        private readonly ProductContext _context;

        public ProductQuery(ProductContext context)
        {
            _context = context;
        }

        public async Task<ProductReadDto> GetProduct(string title)
        {
            return new ProductReadDto();
        }
    }
}
