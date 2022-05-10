namespace Erantissen_Backend.App.Models
{
    public class UpdateHeroRequest
    {
        public int ImageNumber { get; set; }
        public string ImageUrl { get; set; }
        public string Heading { get; set; }
        public string Paragraph { get; set; }
        public string ButtonText { get; set; }
        public string DiscountText { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
