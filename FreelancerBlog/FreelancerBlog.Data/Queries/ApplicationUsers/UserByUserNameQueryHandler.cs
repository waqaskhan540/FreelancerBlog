﻿using System.Threading.Tasks;
using FreelancerBlog.Core.DomainModels;
using FreelancerBlog.Core.Queries.Data.ApplicationUsers;
using FreelancerBlog.Data.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FreelancerBlog.Data.Queries.ApplicationUsers
{
    public class UserByUserNameQueryHandler : AsyncRequestHandler<UserByUserNameQuery, ApplicationUser>
    {
        private FreelancerBlogContext _context;

        public UserByUserNameQueryHandler(FreelancerBlogContext context)
        {
            _context = context;
        }

        protected override Task<ApplicationUser> HandleCore(UserByUserNameQuery message)
        {
            return _context.Users.Include(u => u.Articles)
                                 .ThenInclude(u => u.ArticleRatings)
                                 .Include(u => u.ArticleComments)
                                 .SingleOrDefaultAsync(u => u.Email == message.UserName);
        }
    }
}