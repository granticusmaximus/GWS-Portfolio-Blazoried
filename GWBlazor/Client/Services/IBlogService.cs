using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using GWBlazor.Shared;

namespace GWBlazor.Client.Services
{
    public interface IBlogService
    {
        #region Blog CRUD Actions
        Task<List<Blog>> GetAllBlogs();
        Task AddBlog(Blog blog);
        Task UpdateBlog(Blog blog);
        Blog GetBlogData(long id);
        Task DeleteBlog(long id);
        #endregion

        /*
        #region Post CRUD Actions
        IEnumerable GetAllPosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        Blog GetPostData(long id);
        void DeletePost(long id);
        #endregion

        #region Comment CRUD Actions
        IEnumerable GetAllComments();
        void AddComment(Comment blog);
        void UpdateComment(Comment blog);
        Blog GetCommentData(long id);
        void DeleteComment(long id);
        #endregion
        */
    }
}
