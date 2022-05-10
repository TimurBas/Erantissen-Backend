namespace Erantissen_Backend.App.Models
{
    public class UpdateProductRequest
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
    }
}
