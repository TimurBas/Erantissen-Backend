using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Erantissen_Backend.Data.Models
{
    public class ProductDto
    {
        [Key]
        public string Title { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Tag { get; set; }
    }
}
