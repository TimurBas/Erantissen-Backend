using Erantissen_Backend.App.Models;
using Erantissen_Backend.App.Services.Interfaces;
using Erantissen_Backend.Query.Models;
using Erantissen_Backend.Query.Queries.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Erantissen_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubcategoryController : ControllerBase
    {
        public readonly ISubcategoryService _service;
        public readonly ISubcategoryQuery _query;
        public SubcategoryController(ISubcategoryService service, ISubcategoryQuery query)
        {
            _service = service;
            _query = query;
        }

        [HttpGet("{title}")]
        public ActionResult<SubcategoryReadDto> GetSubcategory(string title)
        {
            var category = _query.GetSubcategory(title);
            return Ok(category);
        }

        [HttpGet()]
        public ActionResult<List<SubcategoryReadDto>> GetSubcategories()
        {
            var categories = _query.GetAll();
            return Ok(categories);
        }

        [HttpGet("category/{categoryTitle}")]
        public ActionResult<List<SubcategoryReadDto>> GetSubcategories(string categoryTitle)
        {
            var categories = _query.GetSubcategories(categoryTitle);
            return Ok(categories);
        }

        [HttpPost()]
        public async Task<ActionResult> CreateSubcategory([FromBody] CreateSubcategoryRequest request)
        {
            await _service.CreateSubcategoryAsync(request);
            return Ok("Subcategory created!");
        }

        [HttpPut("{title}")]
        public async Task<ActionResult> UpdateSubcategory([FromRoute] string title, [FromBody] UpdateSubcategoryRequest request)
        {
            await _service.UpdateSubcategoryAsync(title, request);
            return Ok("Subcategory updated!");
        }

        [HttpDelete("{title}")]
        public async Task<ActionResult> DeleteSubcategory([FromRoute] string title)
        {
            await _service.DeleteSubcategoryAsync(title);
            return Ok($"Subcategory {title} deleted!");
        }
    }
}
