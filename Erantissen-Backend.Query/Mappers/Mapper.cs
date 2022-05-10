using Erantissen_Backend.Data.Models;

namespace Erantissen_Backend.Query.Mappers
{
    public static class Mapper
    {
        internal static ProductReadDto MapProductDtoToReadDto(ProductDto product)
        {
            return new ProductReadDto()
            {
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity
            };
        }
    }
}
