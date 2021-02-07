using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GWBlazor.Shared
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Display(Name = "Date Posted")]
        public DateTime Posted { get; set; }
        [Display(Name = "Date Updated")]
        public DateTime? DateUpdated { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }
}

