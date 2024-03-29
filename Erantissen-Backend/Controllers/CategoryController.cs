﻿using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Models.Requests.Update;
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

    public class CategoryController: ControllerBase
    {
        private readonly ICategoryService _service;
        private readonly ICategoryQuery _query;

        public CategoryController(ICategoryService service, ICategoryQuery query)
        {
            _service = service;
            _query = query;
        }

        [HttpGet("{title}")]
        public ActionResult<CategoryReadDto> GetCategory(string title)
        {
            var category = _query.GetCategory(title);
            return Ok(category);
        }

        [HttpGet]
        public ActionResult<List<CategoryReadDto>> GetCategories()
        {
            var categories = _query.GetAll();
            return Ok(categories);
        }

        [HttpPost()]
        public async Task<ActionResult> CreateCategory([FromBody] CreateCategoryRequest request)
        {
            await _service.CreateCategoryAsync(request);
            return Ok("Category created!");
        }

        [HttpPut("{title}")]
        public async Task<ActionResult> UpdateCategory([FromRoute] string title, [FromBody] UpdateCategoryRequest request)
        {
            await _service.UpdateCategoryAsync(title, request);
            return Ok("Category updated!");
        }

        [HttpDelete("{title}")]
        public async Task<ActionResult> DeleteCategory([FromRoute] string title)
        {
            await _service.DeleteCategoryAsync(title);
            return Ok($"Category {title} deleted!");
        }
    }
}
