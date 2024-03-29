﻿using Erantissen_Backend.App.Models.Requests.Create;
using Erantissen_Backend.App.Models.Requests.Update;
using Erantissen_Backend.App.Services.Interfaces;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }
        public async Task CreateCategoryAsync(CreateCategoryRequest r)
        {
            var category = new Category(r.Title, r.Description);
            await _repo.AddCategoryAsync(category);
        }

        public async Task UpdateCategoryAsync(string title, UpdateCategoryRequest r)
        {
            var category = new Category(title, r.Description);
            await _repo.UpdateCategoryAsync(category);
        }

        public async Task DeleteCategoryAsync(string title)
        {
            await _repo.DeleteCategoryAsync(title);
        }
    }
}
