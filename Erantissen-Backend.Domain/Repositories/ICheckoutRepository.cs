using System.Threading.Tasks;

namespace Erantissen_Backend.Domain.Repositories
{
    public interface ICheckoutRepository
    {
        Task UpdateProduct(string title);
    }
}
