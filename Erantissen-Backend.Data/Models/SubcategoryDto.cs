using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class SubcategoryDto
    {
        public string Title { get; set; }
        [Key]
        public string CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
