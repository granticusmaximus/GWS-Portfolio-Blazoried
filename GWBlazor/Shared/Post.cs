using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GWBlazor.Shared
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Display(Name = "Date Posted")]
        public DateTime Posted { get; set; }
        [Display(Name = "Date Updated")]
        public DateTime? DateUpdated { get; set; }
        public string PostSummary
        {
            get
            {
                if (Content.Length > 50)
                    return Content.Substring(0, 50);

                return Content;
            }
        }

        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }
}

