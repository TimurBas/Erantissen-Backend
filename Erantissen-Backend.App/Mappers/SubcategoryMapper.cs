using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.App.Mappers
{
    public static class SubcategoryMapper
    {
        public static List<Subcategory> MapSubcategories(List<SubcategoryModel> subcategories)
        {
            return subcategories.Select(sc => 
                                            new Subcategory(sc.Title,
                                                            sc.ImageUrl, 
                                                            ProductMapper.MapProducts(sc.Products), 
                                                            ProductMapper.MapProducts(sc.MostBoughtProducts))
                                        )
                                .ToList();
        }

    }
}
