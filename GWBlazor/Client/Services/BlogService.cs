using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GWBlazor.Shared;

namespace GWBlazor.Client.Services
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _http;
        public BlogService(HttpClient http)
        {
            _http = http;
        }

        #region Blog CRUD
        public async Task<List<Blog>> GetAllBlogs()
        {
            return await _http.GetFromJsonAsync<List<Blog>>("api/Blog");
        }

        public Task AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogData(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlog(long id)
        {
            throw new NotImplementedException();
        }
        #endregion


        /*
        #region Post CRUD
        public IEnumerable GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Blog GetPostData(long id)
        {
            throw new NotImplementedException();
        }

        public void DeletePost(long id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Comment CRUD
        public IEnumerable GetAllComments()
        {
            throw new NotImplementedException();
        }

        public void AddComment(Comment blog)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetCommentData(long id)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(long id)
        {
            throw new NotImplementedException();
        }
        #endregion
        */
    }
}
