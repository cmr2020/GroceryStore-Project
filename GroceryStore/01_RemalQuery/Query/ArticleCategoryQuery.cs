﻿using _01_RemalQuery.Contracts.ArticleCategory;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemalQuery.Query
{
    public class ArticleCategoryQuery : IArticleCategoryQuery
    {
        private readonly BlogContext _context;

        public ArticleCategoryQuery(BlogContext context)
        {
            _context = context;
        }

        public List<ArticleCategoryQueryModel> GetArticleCategories()
        {
            return _context.ArticleCategories
                 .Include(x => x.Articles)
                 .Select(x => new ArticleCategoryQueryModel
                 {
                     Name = x.Name,
                     Picture = x.Picture,
                     PictureAlt = x.PictureAlt,
                     PictureTitle = x.PictureTitle,
                     Slug = x.Slug,
                     ArticlesCount = x.Articles.Count
                 }).ToList();
        }
    }
}
