using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class CategoryDto
    {
        [Key]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public List<SubcategoryDto> Subcategories { get; set; }
    }
}
