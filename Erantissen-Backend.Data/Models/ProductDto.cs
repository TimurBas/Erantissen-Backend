using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Erantissen_Backend.Data.Models
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        [Key]
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string Tag { get; set; }
    }
}
