using System;

namespace Erantissen_Backend.Domain.Entities
{
    public class Product
    {
        public readonly Guid Id;
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }

        public Product(Guid id, string title, decimal price, string description, int? quantity)
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Quantity = quantity;
        }
    }
}
