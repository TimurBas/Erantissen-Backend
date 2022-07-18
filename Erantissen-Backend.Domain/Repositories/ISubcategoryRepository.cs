using Erantissen_Backend.Domain.Entities;
using System.Threading.Tasks;

namespace Erantissen_Backend.Domain.Repositories
{
    public interface ISubcategoryRepository
    {
        Task AddSubcategoryAsync(Subcategory subcategory, string categoryTitle);
        Task UpdateSubcategoryAsync(Subcategory subcategory);
        Task DeleteSubcategoryAsync(string title);
    }
}
