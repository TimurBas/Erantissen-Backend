using System.Collections.Generic;

namespace Erantissen_Backend.Data.Models
{
    public class SubcategoryDto
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<ProductDto> Products { get; set; }
        public string CategoryTitle { get; set; }
        public CategoryDto Category { get; set; }
    }
}
