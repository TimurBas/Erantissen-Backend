using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Domain.Entities;
using System.Linq;

namespace Erantissen_Backend.Data.Mappers
{
    public class CategoryMapper
    {
        internal static CategoryDto MapDomainToDto(Category category)
        {
            return new CategoryDto()
            {
                Title = category.Title,
                Description = category.Description,
            };
        }

        internal static void UpdateDtoFields(CategoryDto categoryDto, Category category)
        {
            categoryDto.Description = category.Description;
        }
    }
}
