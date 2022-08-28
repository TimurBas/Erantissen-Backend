using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
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

            _client.BaseAddress = new Uri(_config["ReepayBaseUrl"]);
            var request = new HttpRequestMessage(HttpMethod.Post, "/v1/session/charge");
            var content = new StringContent(JsonSerializer.Serialize(r), Encoding.UTF8, "application/json");
            request.Content = content;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _config["ReepaySecretKey"]);

            var response = await _client.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return BadRequest(responseContent);

            return Ok(responseContent);
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateProduct([FromRoute] string title)
        {
            await _service.UpdateProduct(title);
            return Ok("");
        }
    }
}
