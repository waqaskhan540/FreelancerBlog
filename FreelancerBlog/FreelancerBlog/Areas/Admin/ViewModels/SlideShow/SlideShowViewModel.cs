﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace FreelancerBlog.Areas.Admin.ViewModels.SlideShow
{
    public class SlideShowViewModel
    {
        public SlideShowViewModel()
        {
            SlideShowDateCreated = DateTime.Now;
        }

        public int SlideShowId { get; set; }


        [Display(Name ="تاریخ ایجاد")]
        public DateTime SlideShowDateCreated { get; set; }


        [Display(Name = "اولویت")]
        [Required(ErrorMessage = "پر کردن این فیلد الزامی میباشد.")]
        public int? SlideShowPriority { get; set; }


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "پر کردن این فیلد الزامی میباشد.")]
        public string SlideShowTitle { get; set; }


        [Display(Name = "متن")]
        [Required(ErrorMessage = "پر کردن این فیلد الزامی میباشد.")]
        public string SlideShowBody { get; set; }


        [Display(Name = "عکس")]
        public string SlideShowPictrure { get; set; }


        [Display(Name = "عکس")]
        [Required(ErrorMessage = "پر کردن این فیلد الزامی میباشد.")]
        public IFormFile SlideShowPictrureFile { get; set; }

        [Display(Name = "لینک")]
        public string SlideShowLink { get; set; }
    }
}
