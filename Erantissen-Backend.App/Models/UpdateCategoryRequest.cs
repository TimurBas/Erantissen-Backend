using Erantissen_Backend.Domain.Entities;
using System.Collections.Generic;

namespace Erantissen_Backend.App.Models
{
    public class UpdateCategoryRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Subcategory> Subcategories { get; set; }
    }
}
