using _01_RemalQuery.Contracts.ArticleCategory;
using _01_RemalQuery.Contracts.ProductCategory;
using System.Collections.Generic;

namespace _01_RemalQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
