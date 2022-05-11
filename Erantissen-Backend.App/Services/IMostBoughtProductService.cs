﻿using Erantissen_Backend.App.Models;
using System.Threading.Tasks;

namespace Erantissen_Backend.App.Services
{
    public interface IMostBoughtProductService
    {
        Task CreateProduct(CreateProductRequest r);
        Task UpdateProduct(UpdateProductRequest r);
        Task DeleteProduct(string title);
    }
}
