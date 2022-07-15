using System.Collections.Generic;

namespace Erantissen_Backend.Query.Models
{
    public class SubcategoryReadDto
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<ProductReadDto> Products { get; set; }
        public List<ProductReadDto> MostBoughtProducts { get; set; }
    }
}
