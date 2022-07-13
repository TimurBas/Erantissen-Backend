using System.Collections.Generic;

namespace Erantissen_Backend.Query.Models
{
    public class CategoryReadDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubcategoryReadDto> Subcategories { get; set; }
    }
}
