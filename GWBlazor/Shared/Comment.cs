using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GWBlazor.Shared
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CommentID { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
        public int PostID { get; set; }
    }
}
