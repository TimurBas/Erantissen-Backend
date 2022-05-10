using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Query.Mappers;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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

        public ProductReadDto GetProduct(string title)
        {
            var product = _context.Products.AsNoTracking().Where(p => p.Title.Equals(title)).FirstOrDefault();
            var mappedProduct = Mapper.MapProductDtoToReadDto(product);
            return mappedProduct;
        }
    }
}
