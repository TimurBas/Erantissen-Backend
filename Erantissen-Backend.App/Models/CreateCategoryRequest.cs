﻿using System.Collections.Generic;

namespace Erantissen_Backend.App.Models
{
    public class CreateCategoryRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubcategoryModel> Subcategories { get; set; }
    }
}
