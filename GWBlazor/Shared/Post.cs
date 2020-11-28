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
        public string Content { get; set; }
        public Blog Blog { get; set; }
        public int BlogID { get; set; }
        [Display(Name = "Date Posted")]
        public DateTime DatePosted { get; set; }
        [Display(Name = "Date Updated")]
        public DateTime? DateUpdated { get; set; }
        public List<Comment> Comments { get; set; }
    }
}

