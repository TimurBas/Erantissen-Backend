namespace Erantissen_Backend.Domain.Entities
{
    public class Hero
    {
        public int ImageNumber { get; set; }
        public string Heading { get; set; }
        public string Paragraph { get; set; }
        public string ButtonText { get; set; }
        public string DiscountText { get; set; }

        public Hero(string heading, string paragraph, string buttonText, string discountText)
        {
            Heading = heading;
            Paragraph = paragraph;
            ButtonText = buttonText;
            DiscountText = discountText;
        }
    }
}
