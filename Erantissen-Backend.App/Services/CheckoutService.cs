using Erantissen_Backend.App.Services.Interfaces;
using Erantissen_Backend.Domain.Repositories;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public class CheckoutService : ICheckoutService
    {
        private readonly ICheckoutRepository _repo;
        public CheckoutService(ICheckoutRepository repo)
        {
            _repo = repo;
        }
        public async Task UpdateProduct(string title)
        {
            await _repo.UpdateProduct(title);
        }
    }
}
