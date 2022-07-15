using System.Collections.Generic;

namespace Erantissen_Backend.App.Models
{
    public class SubcategoryModel
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<ProductModel> Products { get; set; }
        public List<ProductModel> MostBoughtProducts { get; set; }
    }
}
