using System;
using System.Collections.Generic;
using GWBlazor.Shared;

namespace GWBlazor.Client.Services
{
    public interface IBlogService
    {
        List<Post> GetBlogPosts();
        Post GetBlogPost(int id);
        Post AddBlogPost(Post newBlogPost);
        void UpdateBlogPost(int postId, string updatePost, string updateTitle);
        void DeleteBlogPost(int postId);
    }
}
