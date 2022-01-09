using _0_Framework.Application;
using _01_RemalQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemalQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
      

        public ArticleQuery(BlogContext context)
        {
            _context = context;         
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
                 .Include(x => x.Category)
                 .Where(x => x.PublishDate <= DateTime.Now)
                 .Select(x => new ArticleQueryModel
                 {
                     CategoryId=x.CategoryId,
                     CategoryName=x.Category.Name,
                     CategorySlug=x.Category.Slug,
                     Title = x.Title,
                     Slug = x.Slug,
                     CanonicalAddress=x.CanonicalAddress,
                     Description=x.Description,
                     Keywords=x.Keywords,
                     MetaDescription=x.MetaDescription,
                     Picture = x.Picture,
                     PictureAlt = x.PictureAlt,
                     PictureTitle = x.PictureTitle,
                     PublishDate = x.PublishDate.ToFarsi(),
                     ShortDescription = x.ShortDescription,
                 }).ToList();
        }
    }
}
