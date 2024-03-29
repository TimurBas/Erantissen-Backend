﻿using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Domain.Entities;

namespace Erantissen_Backend.Data.Mappers
{
    public static class ProductMapper
    {
        internal static ProductDto MapDomainToDto(Product product, string subcategoryTitle)
        {
            return new ProductDto()
            {
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity,
                ImageUrl = product.ImageUrl,
                BoughtNoOfTimes = 0,
                SubcategoryTitle = subcategoryTitle,
            };
        }

        internal static void UpdateDtoFields(ProductDto productDto, Product product)
        {
            productDto.Title = product.Title;
            productDto.Price = product.Price;
            productDto.Description = product.Description;
            productDto.Quantity = product.Quantity;
            productDto.ImageUrl = product.ImageUrl;
        }
    }
}
