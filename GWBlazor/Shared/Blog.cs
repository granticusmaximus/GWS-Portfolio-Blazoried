using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GWBlazor.Shared
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [Display(Name = "Blog Name")]
        public string Title { get; set; }
        public List<Post> Posts { get; set; }
    }
}
