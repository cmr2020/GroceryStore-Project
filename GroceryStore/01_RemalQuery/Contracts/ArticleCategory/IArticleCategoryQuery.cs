using System.Collections.Generic;

namespace _01_RemalQuery.Contracts.ArticleCategory
{
    public interface IArticleCategoryQuery
    {  
        List<ArticleCategoryQueryModel> GetArticleCategories();
    }
}
