using Erantissen_Backend.App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Erantissen_Backend.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ICheckoutService _service;
        public CheckoutController(ICheckoutService service)
        {
            _service = service;
        }
        [HttpPatch]
        public async Task<ActionResult> UpdateProduct([FromRoute] string title)
        {
            await _service.UpdateProduct(title);
            return Ok("");
        }
    }
}
