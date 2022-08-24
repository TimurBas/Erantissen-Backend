namespace Erantissen_Backend.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }

        public Product(string title, decimal price, string description, int quantity, string imageUrl)
        {
            Title = title;
            Price = price;
            Description = description;
            Quantity = quantity;
            ImageUrl = imageUrl;
        }
    }
}
