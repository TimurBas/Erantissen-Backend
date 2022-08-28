using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Stripe;
using Stripe.Checkout;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Erantissen_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly ICheckoutService _service;
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public CheckoutController(ICheckoutService service, HttpClient httpClient, IConfiguration config)
        {
            _service = service;
            _client = httpClient;
            _config = config;
        }

        [HttpPost()]
        public async Task<ActionResult> CreateNewPayment([FromBody] CreateNewPaymentRequest r)
        {
            StripeConfiguration.ApiKey = "sk_test_51Laz4cEUjePeoHs8en4zX6MMYxeWB6XJuWBOXQzvc2vQnf0oRjcGoFS54KgWSCTd11cSrceRCSaI2PEqewV5xMLF00sx9mMIFi";

            var options = new SessionCreateOptions
            {
                SuccessUrl = r.SuccessUrl,
                CancelUrl = r.CancelUrl,
                Mode = r.Mode,
                LineItems = r.LineItems.Select(i => new SessionLineItemOptions()
                {
                    Price = $"price_{Guid.NewGuid()}",
                    Quantity = i.Quantity,
                    PriceData = new SessionLineItemPriceDataOptions()
                    {
                        Currency = i.Price.Currency,

                    }
                }).ToList()
            };

            var service = new SessionService();
            service.Create(options);



            _client.BaseAddress = new Uri(_config["StripeBaseUrl"]);
            var content = new StringContent(JsonSerializer.Serialize(r), Encoding.UTF8, "application/json");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_config["NetsEasyTestSecretKey"]);

            var response = await _client.PostAsync("/v1/payments", content);

            if (!response.IsSuccessStatusCode)
                return BadRequest();

            var responseContent = await response.Content.ReadAsStringAsync();
            return Ok(responseContent);
        }

        [HttpPatch()]
        public async Task<ActionResult> UpdateProduct([FromRoute] string title)
        {
            await _service.UpdateProduct(title);
            return Ok("");
        }
    }
}
