using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class SubcategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<ProductDto> Products { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
