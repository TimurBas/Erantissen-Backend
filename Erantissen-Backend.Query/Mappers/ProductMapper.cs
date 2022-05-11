using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Query.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Erantissen_Backend.Query.Mappers
{
    public static class ProductMapper
    {
        internal static ProductReadDto MapDtoToReadDto(ProductDto product)
        {
            return new ProductReadDto()
            {
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity,
                ImageUrl = product.ImageUrl,
                Tag = product.Tag
            };
        }

        internal static List<ProductReadDto> MapAll(List<ProductDto> products)
        {
            return products.Select(p => MapDtoToReadDto(p)).ToList();
        }

        internal static ProductReadDto MapMostBoughtDtoToReadDto(MostBoughtProductDto product)
        {
            return new ProductReadDto()
            {
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity,
                ImageUrl = product.ImageUrl,
                Tag = product.Tag
            };
        }

        internal static List<ProductReadDto> MapAllMostBought(List<MostBoughtProductDto> products)
        {
            return products.Select(p => MapMostBoughtDtoToReadDto(p)).ToList();
        }
    }
}
