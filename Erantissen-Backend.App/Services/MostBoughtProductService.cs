﻿using Erantissen_Backend.App.Models;
using Erantissen_Backend.Domain.Entities;
using Erantissen_Backend.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public class MostBoughtProductService : IMostBoughtProductService
    {
        private readonly IMostBoughtProductRepository _repo;

        public MostBoughtProductService(IMostBoughtProductRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateProduct(CreateProductRequest r)
        {
            await _repo.AddProductAsync(new Product(r.Title, r.Price, r.Description, r.Quantity, r.ImageUrl));
        }
        public async Task UpdateProduct(UpdateProductRequest r)
        {
            await _repo.UpdateProductAsync(new Product(r.Title, r.Price, r.Description, r.Quantity, r.ImageUrl));
        }

        public async Task DeleteProduct(string title)
        {
            await _repo.DeleteProductAsync(title);
        }
    }
}
