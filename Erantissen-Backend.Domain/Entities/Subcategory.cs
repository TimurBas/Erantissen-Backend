using System.Collections.Generic;

namespace Erantissen_Backend.Domain.Entities
{
    public class Subcategory
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<Product> Products { get; set; }
        public List<Product> MostBoughtProducts { get; set; }
        public Subcategory(string title, string imageUrl, List<Product> products, List<Product> mostBoughtProducts)
        {
            Title = title;
            ImageUrl = imageUrl;
            Products = products;
            MostBoughtProducts = mostBoughtProducts;
        }
    }
}
