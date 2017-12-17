﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FreelancerBlog.Core.DomainModels;
using FreelancerBlog.Core.Queries.Data.ArticleTags;
using FreelancerBlog.Data.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FreelancerBlog.Data.Queries.ArticleTags
{
    class FindArticleTagByIdQueryHandler: AsyncRequestHandler<FindArticleTagByIdQuery, ArticleTag>
    {
        private FreelancerBlogContext _context;

        public FindArticleTagByIdQueryHandler(FreelancerBlogContext context)
        {
            _context = context;
        }

        protected override Task<ArticleTag> HandleCore(FindArticleTagByIdQuery message)
        {
            return _context.ArticleTags.SingleOrDefaultAsync(a => a.ArticleTagId == message.ArticleTagId);
        }
    }
}