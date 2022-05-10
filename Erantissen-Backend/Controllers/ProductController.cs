﻿using Erantissen_Backend.App.Models;
using Erantissen_Backend.App.Services;
using Erantissen_Backend.Query;
using Erantissen_Backend.Query.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Erantissen_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IProductQuery _query;

        public ProductController(IProductService service, IProductQuery query)
        {
            _service = service;
            _query = query;
        }

        [HttpGet("{title}")]
        public async Task<ActionResult<ProductReadDto>> GetProduct([FromRoute] string title)
        {
            var product = await _query.GetProduct(title);
            return Ok(product);
        }

        [HttpPost()]
        public async Task<ActionResult> CreateProduct(CreateProductRequest request)
        {
            await _service.CreateProduct(request);
            return Ok($"Product {request.Title} successfully created");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateProduct(UpdateProductRequest request)
        {
            await _service.UpdateProduct(request);
            return Ok($"Product {request.Title} successfully updated");
        }

        [HttpDelete("{title}")]
        public async Task<ActionResult> DeleteProduct([FromRoute] string title)
        {
            await _service.DeleteProduct(title);
            return Ok($"Product {title} successfully deleted");
        }
    }
}