using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Query.Mappers;
using Erantissen_Backend.Query.Models;
using Erantissen_Backend.Query.Queries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Queries
{
    public class ProductQuery : IProductQuery
    {
        private readonly Context _context;

        public ProductQuery(Context context)
        {
            _context = context;
        }

        public ProductReadDto GetProduct(string title)
        {
            var product = _context.Products.AsNoTracking().Where(p => p.Title.Equals(title)).FirstOrDefault();
            var mappedProduct = ProductMapper.MapDtoToReadDto(product);
            return mappedProduct;
        }

        public List<ProductReadDto> GetAll()
        {
            var products = _context.Products.AsNoTracking().ToList();
            var mappedProducts = ProductMapper.MapAll(products);
            return mappedProducts;
        }
    }
}
