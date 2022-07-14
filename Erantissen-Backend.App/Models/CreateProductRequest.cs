﻿namespace Erantissen_Backend.App.Models
{
    public class CreateProductRequest
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
    }
}
