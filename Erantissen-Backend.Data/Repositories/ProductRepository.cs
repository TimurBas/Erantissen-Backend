using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Data.Mappers;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Erantissen_Backend.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            var mappedProduct = ProductMapper.MapDomainToDto(product);
            await _context.Products.AddAsync(mappedProduct);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            var productDto = _context.Products.Where(p => p.Title.Equals(product.Title)).FirstOrDefault();
            ProductMapper.UpdateDtoFields(productDto, product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(string title)
        {
            var product = _context.Products.Where(p => p.Title.Equals(title)).FirstOrDefault();
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
