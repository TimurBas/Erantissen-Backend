using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.App.Factories
{
    public class CategoryFactory
    {
        public static Category CreateCategory(string title, string description, List<SubcategoryModel> subcategoryDtos)
        {
            var category = new Category(title, description);
            var subcategories = subcategoryDtos.Select(sc => SubcategoryFactory.CreateSubcategory(sc.Title,
                                                                                                  sc.ImageUrl, 
                                                                                                  sc.Products, 
                                                                                                  sc.MostBoughtProducts,
                                                                                                  category))
                                               .ToList();
            category.Subcategories = subcategories;
            return category;

        }
    }
}
