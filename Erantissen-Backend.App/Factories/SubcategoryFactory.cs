using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.App.Factories
{
    public class SubcategoryFactory
    {
        public static Subcategory CreateSubcategory(string title,
                                                    string imageUrl,
                                                    List<ProductModel> productDtos,
                                                    List<ProductModel> mostBoughtProductDtos,
                                                    Category category)
        {
            var subcategory = new Subcategory(title, imageUrl)
            {
                Category = category
            };
            var products = productDtos.Select(p => ProductFactory.CreateProduct(p.Title, 
                                                                                p.Description, 
                                                                                p.Price, 
                                                                                p.Quantity,
                                                                                p.ImageUrl, 
                                                                                subcategory)).ToList();
            var mostBoughtProducts = mostBoughtProductDtos.Select(mbp => ProductFactory.CreateProduct(mbp.Title,
                                                                                            mbp.Description, 
                                                                                            mbp.Price, 
                                                                                            mbp.Quantity, 
                                                                                            mbp.ImageUrl, 
                                                                                            subcategory)).ToList();
            subcategory.Products = products;
            subcategory.MostBoughtProducts = mostBoughtProducts;

            return subcategory;
        }

    }
}
