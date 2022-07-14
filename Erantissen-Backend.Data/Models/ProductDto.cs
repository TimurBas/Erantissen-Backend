using System;
using System.ComponentModel.DataAnnotations;

namespace Erantissen_Backend.Data.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public int SubcategoryId { get; set; }
        public SubcategoryDto Subcategory { get; set; }
    }
}
