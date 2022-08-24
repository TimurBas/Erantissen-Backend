using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services.Interfaces
{
    public interface ICheckoutService
    {
        Task UpdateProduct(string title); 
    }
}
