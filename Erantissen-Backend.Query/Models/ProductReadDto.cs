using System;

namespace Erantissen_Backend.Query
{
    public class ProductReadDto
    {
        public readonly Guid Id;
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
    }
}
