using System;

namespace Erantissen_Backend.Domain.Entities
{
    public class Product
    {
        public readonly Guid Id = Guid.NewGuid();
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }

        public Product(string title, decimal price, string description, int? quantity)
        {
            Title = title;
            Price = price;
            Description = description;
            Quantity = quantity;
        }
    }
}
