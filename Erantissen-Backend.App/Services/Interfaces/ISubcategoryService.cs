using Erantissen_Backend.App.Models;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services.Interfaces
{
    public interface ISubcategoryService
    {
        Task CreateSubcategoryAsync(CreateSubcategoryRequest r);
        Task UpdateSubcategoryAsync(string title, UpdateSubcategoryRequest r);
        Task DeleteSubcategoryAsync(string title);
    }
}
