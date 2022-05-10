using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Domain.Entities;

namespace Erantissen_Backend.Data.Mappers
{
    public static class Mapper
    {
        internal static ProductDto MapDomainProductToDto(Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity,
                ImageUrl = product.ImageUrl,
                Tag = product.Tag
            };
        }

        internal static void UpdateProductDtoFields(ProductDto productDto, Product product)
        {
            productDto.Title = product.Title;
            productDto.Price = product.Price;
            productDto.Description = product.Description;
            productDto.Quantity = product.Quantity;
            productDto.ImageUrl = product.ImageUrl;
            productDto.Tag = product.Tag;
        }
    }
}
