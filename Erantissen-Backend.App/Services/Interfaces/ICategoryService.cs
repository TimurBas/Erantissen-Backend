using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Models.Requests.Update;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services.Interfaces
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryRequest r);
        Task UpdateCategoryAsync(string title, UpdateCategoryRequest r);
        Task DeleteCategoryAsync(string title);
    }
}
