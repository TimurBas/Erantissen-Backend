using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class HeroDto
    {
        [Key]
        public int ImageNumber { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Heading { get; set; }
        [Required]
        public string Paragraph { get; set; }
        [Required]
        public string ButtonText { get; set; }
        public string DiscountText { get; set; }
    }
}
