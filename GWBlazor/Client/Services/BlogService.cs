using System.Collections.Generic;
using System.Linq;
using GWBlazor.Shared;

namespace GWBlazor.Client.Services
{
    public class BlogService
    {
        private List<Post> _blogPosts;

        public BlogService()
        {
            _blogPosts = new List<Post>();
        }

        public List<Post> GetBlogPosts()
        {
            return _blogPosts;
        }

        public Post GetBlogPost(int id)
        {
            return _blogPosts.SingleOrDefault(x => x.PostID == id);
        }

        public Post AddBlogPost(Post newBlogPost)
        {
            newBlogPost.PostID = _blogPosts.Count + 1;
            _blogPosts.Add(newBlogPost);

            return newBlogPost;
        }
    }
}
