using Erantissen_Backend.Query.Models;
using System.Collections.Generic;

namespace Erantissen_Backend.Query.Queries.Interfaces
{
    public interface ISubcategoryQuery
    {
        SubcategoryReadDto GetSubcategory(string title);
        List<SubcategoryReadDto> GetAll();
        List<SubcategoryReadDto> GetSubcategories(string categoryTitle);
    }
}
