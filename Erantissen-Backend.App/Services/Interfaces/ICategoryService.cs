using Erantissen_Backend.App.Models;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryRequest r);
        Task UpdateCategoryAsync(string title, UpdateCategoryRequest r);
        Task DeleteCategoryAsync(string title);
    }
}
