﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreelancerBlog.Core.DomainModels;
using FreelancerBlog.Core.Queries.Data.Articles;
using FreelancerBlog.Data.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FreelancerBlog.Data.Queries.Articles
{
    public class ArticlesByTagQueryHandler : RequestHandler<ArticlesByTagQuery, IQueryable<Article>>
    {
        private FreelancerBlogContext _context;

        public ArticlesByTagQueryHandler(FreelancerBlogContext context)
        {
            _context = context;
        }

        protected override IQueryable<Article> HandleCore(ArticlesByTagQuery message)
        {
            return _context.ArticleArticleTags.Where(a => a.ArticleTagId == message.TagId)
                    .Join(_context.Articles.Include(a => a.ApplicationUser)
                                           .Include(a => a.ArticleComments)
                                           .Include(a => a.ArticleRatings), left => left.ArticleId, right => right.ArticleId, (aat, a) => a)
                                           .AsQueryable();
        }
    }
}