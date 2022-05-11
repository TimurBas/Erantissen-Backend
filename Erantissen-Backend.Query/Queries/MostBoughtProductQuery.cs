using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Query.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Queries
{
    public class MostBoughtProductQuery : IMostBoughtProductQuery
    {
        private readonly Context _context;
        public MostBoughtProductQuery(Context context)
        {
            _context = context;
        }
        public List<ProductReadDto> GetAll()
        {
            var products = _context.MostBoughtProducts.AsNoTracking().ToList();
            var mappedProducts = ProductMapper.MapAllMostBought(products);
            return mappedProducts;
        }
    }
}
