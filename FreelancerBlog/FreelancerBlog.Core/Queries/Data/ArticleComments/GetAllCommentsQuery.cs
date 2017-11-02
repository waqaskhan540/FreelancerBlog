﻿using System.Linq;
using FreelancerBlog.Core.DomainModels;
using MediatR;

namespace FreelancerBlog.Core.Queries.Data.ArticleComments
{
    public class GetAllCommentsQuery: IRequest<IQueryable<ArticleComment>> { }
}