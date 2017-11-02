﻿using FreelancerBlog.Core.DomainModels;
using MediatR;

namespace FreelancerBlog.Core.Commands.Data.SlideShows
{
    public class DeleteSlideShowCommand : IRequest
    {
        public SlideShow SlideShow { get; set; }
    }
}