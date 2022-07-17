﻿using Erantissen_Backend.Data.Models;
using Erantissen_Backend.Domain.Entities;
using System.Linq;

namespace Erantissen_Backend.Data.Mappers
{
    public static class SubcategoryMapper
    {
        public static SubcategoryDto MapDomainToDto(Subcategory subcategory)
        {
            return new SubcategoryDto()
            {
                Title = subcategory.Title,
                ImageUrl = subcategory.ImageUrl,
                Products = subcategory.Products.Select(p => ProductMapper.MapDomainToDto(p)).ToList(),
                MostBoughtProducts = subcategory.MostBoughtProducts.Select(mbp => ProductMapper.MapDomainToMostBoughtDto(mbp)).ToList()
            };
        }

        public static void UpdateDtoFields(SubcategoryDto subcategoryDto, Subcategory subcategory)
        {
            subcategoryDto.ImageUrl = subcategory.ImageUrl;
        }
    }
}
