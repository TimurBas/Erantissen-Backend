using System;
using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class MostBoughtProductDto
    {
        [Key]
        public string Title { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string SubcategoryId { get; set; }
        public SubcategoryDto Subcategory { get; set; }
    }
}
