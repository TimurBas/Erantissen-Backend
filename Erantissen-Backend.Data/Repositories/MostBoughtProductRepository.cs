using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Data.Mappers;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Erantissen_Backend.Data.Repositories
{
    public class MostBoughtProductRepository : IMostBoughtProductRepository
    {
        private readonly Context _context;

        public MostBoughtProductRepository(Context context)
        {
            _context = context;
        }
        public async Task AddProductAsync(Product product)
        {
            var mappedProduct = ProductMapper.MapDomainToMostBoughtDto(product);
            await _context.MostBoughtProducts.AddAsync(mappedProduct);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            var productDto = _context.MostBoughtProducts.Where(p => p.Title.Equals(product.Title)).FirstOrDefault();
            ProductMapper.UpdateMostBoughtDtoFields(productDto, product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(string title)
        {
            var product = _context.MostBoughtProducts.Where(p => p.Title.Equals(title)).FirstOrDefault();
            _context.MostBoughtProducts.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
