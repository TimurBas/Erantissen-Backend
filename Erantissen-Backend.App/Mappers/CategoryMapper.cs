using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.App.Mappers
{
    public static class CategoryMapper
    {
        public static List<Subcategory> MapSubcategories(List<SubcategoryModel> subcategories)
        {
            return subcategories.Select(sc => new Subcategory(sc.Title, sc.ImageUrl, MapProducts(sc.Products), MapProducts(sc.MostBoughtProducts))).ToList();
        }

        public static List<Product> MapProducts(List<ProductModel> products)
        {
            return products.Select(p => new Product(p.Title, p.Price, p.Description, p.Quantity, p.ImageUrl)).ToList();
        }
    }
}
