using Erantissen_Backend.Domain.Entities;
using System.Threading.Tasks;

namespace Erantissen_Backend.Domain.Repositories
{
    public interface ISubcategoryRepository
    {
        Task AddSubcategoryAsync(Subcategory subcategory);
        Task UpdateSubcategoryAsync(Subcategory subcategory);
        Task DeleteSubcategoryAsync(string title);
    }
}
