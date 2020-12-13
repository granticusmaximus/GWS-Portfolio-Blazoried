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

        public void UpdateBlogPost(int postId, string updatedPost, string updateTitle)
        {
            var originalBlogPost = _blogPosts.Find(x => x.Id == postId);

            originalBlogPost.Post = updatedPost;
            originalBlogPost.Title = updateTitle;
        }

        public void DeleteBlogPost(int postId)
        {
            var blogPost = _blogPosts.Find(x => x.Id == postId);

            _blogPosts.Remove(blogPost);
        }
    }
}
