﻿using System.Linq;
using FreelancerBlog.Core.DomainModels;
using MediatR;

namespace FreelancerBlog.Core.Queries.Data.SlideShows
{
    public class AllSlideShowsQuery : IRequest<IQueryable<SlideShow>> { }
}