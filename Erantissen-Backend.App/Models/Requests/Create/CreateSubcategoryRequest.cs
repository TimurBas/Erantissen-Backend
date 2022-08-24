using System.Collections.Generic;

namespace Erantissen_Backend.App.Models.Requests.Create
{
    public class CreateSubcategoryRequest
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryTitle { get; set; }
    }
}
