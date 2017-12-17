﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FreelancerBlog.Core.DomainModels;
using FreelancerBlog.Core.Queries.Data.SlideShows;
using FreelancerBlog.Data.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FreelancerBlog.Data.Queries.SlideShows
{
    public class SlideShowByIdQueryHandler : AsyncRequestHandler<SlideShowByIdQuery, SlideShow>
    {
        private FreelancerBlogContext _context;

        public SlideShowByIdQueryHandler(FreelancerBlogContext context)
        {
            _context = context;
        }

        protected override Task<SlideShow> HandleCore(SlideShowByIdQuery message)
        {
           return _context.SlideShows.SingleAsync(s => s.SlideShowId == message.SlideShowId);
        }
    }
}