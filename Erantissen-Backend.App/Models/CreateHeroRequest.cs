﻿namespace Erantissen_Backend.App.Models
{
    public class CreateHeroRequest
    {
        public string ImageUrl { get; set; }
        public string Heading { get; set; }
        public string Paragraph { get; set; }
        public string ButtonText { get; set; }
        public string DiscountText { get; set; }
    }
}
