namespace Erantissen_Backend.Data.Models
{
    public class MostBoughtProductDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string SubcategoryTitle { get; set; }
        public SubcategoryDto Subcategory { get; set; }
    }
}
