using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class CategoryDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubcategoryDto> Subcategories { get; set; }
    }
}
