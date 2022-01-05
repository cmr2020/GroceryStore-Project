using _01_RemalQuery.Contracts.Product;
using _01_RemalQuery.Contracts.ProductCategory;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemalQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryQuery
    {
        private readonly ShopContext _context;

        public ProductCategoryQuery(ShopContext context)
        {
            _context = context;
        }

        public List<ProductCategoryQueryModel> GetProductCategories()
        {
            return _context.ProductCategories.Select(x => new ProductCategoryQueryModel
            {
                Id = x.ID,
                Name = x.Name,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug
            }).ToList();
        }

        public List<ProductCategoryQueryModel> GetProductCategoriesWithProducts()
        {
            return _context.ProductCategories
                 .Include(x => x.Products)
                 .ThenInclude(x => x.Category)
                 .Select(x => new ProductCategoryQueryModel
                 {
                     Id = x.ID,
                     Name = x.Name,
                     Products = MapProducts(x.Products)
                 }).AsNoTracking().ToList();
        }

        private static List<ProductQueryModel> MapProducts(List<Product> products)
        {

            var result = new List<ProductQueryModel>();

            foreach (var product in products)
            {
                var item = new ProductQueryModel
                {
                    Id = product.ID,
                    Category = product.Category.Name,
                    Name = product.Name,
                    Picture = product.Picture,
                    PictureAlt = product.PictureAlt,
                    PictureTitle = product.PictureTitle,
                    Slug = product.Slug

                };
                result.Add(item);
            }
            return result;
        }

    }
}
