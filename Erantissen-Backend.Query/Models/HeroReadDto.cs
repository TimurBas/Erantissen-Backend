namespace Erantissen_Backend.Query.Models
{
    public class HeroReadDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Heading { get; set; }
        public string Paragraph { get; set; }
        public string ButtonText { get; set; }
        public string DiscountText { get; set; }
        public string Discount { get; set; }
    }
}
