using System.Collections.Generic;

namespace Erantissen_Backend.Domain.Entities
{
    public class Category
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Subcategory> Subcategories { get; set; }

        public Category(string title, string description, List<Subcategory> subcategories)
        {
            Title = title;
            Description = description;
            Subcategories = subcategories;
        }
    }
}
