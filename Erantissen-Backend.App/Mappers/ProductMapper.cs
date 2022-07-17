using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.App.Mappers
{
    public static class ProductMapper
    {
        public static List<Product> MapProducts(List<ProductModel> products)
        {
            return products.Select(p => new Product(p.Title, p.Price, p.Description, p.Quantity, p.ImageUrl)).ToList();
        }
    }
}
