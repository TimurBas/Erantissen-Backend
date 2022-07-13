using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class SubcategoryDto
    {
        [Key]
        public string Title { get; set; }
    }
}
