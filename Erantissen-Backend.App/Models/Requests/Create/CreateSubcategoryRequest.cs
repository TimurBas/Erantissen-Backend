using System.Collections.Generic;

namespace Erantissen_Backend.App.Models.Requests.Create
{
    public class CreateSubcategoryRequest
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<ProductModel> Products { get; set; }
        public List<ProductModel> MostBoughtProducts { get; set; }
        public string CategoryTitle { get; set; }
    }
}
