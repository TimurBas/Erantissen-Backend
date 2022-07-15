﻿using Erantissen_Backend.Data.Models;
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
                Subcategories = category.Subcategories.Select(sc => MapDomainToDto(sc)).ToList()
            };
        }

        internal static void UpdateDtoFields(CategoryDto categoryDto, Category category)
        {
            categoryDto.Description = category.Description;
        }

        private static SubcategoryDto MapDomainToDto(Subcategory subcategory)
        {
            return new SubcategoryDto()
            {
                Title = subcategory.Title,
                ImageUrl = subcategory.ImageUrl,
                Products = subcategory.Products.Select(p => ProductMapper.MapDomainToDto(p)).ToList(),
                MostBoughtProducts = subcategory.MostBoughtProducts.Select(mbp => ProductMapper.MapDomainToMostBoughtDto(mbp)).ToList()
            };
        }
    }
}
