using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erantissen_Backend.Data.Models
{
    public class CategoryDto
    {
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubcategoryDto> Subcategories { get; set; }
    }
}
