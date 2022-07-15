using Erantissen_Backend.Domain.Entities;
using System.Threading.Tasks;

namespace Erantissen_Backend.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(string title);
    }
}
