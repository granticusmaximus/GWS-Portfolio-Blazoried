using System;
using System.ComponentModel.DataAnnotations;

namespace GWBlazor.Shared
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
        public int PostID { get; set; }
    }
}
