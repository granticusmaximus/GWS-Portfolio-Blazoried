using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using GWBlazor.Shared;
using GWBlazor.Client.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GWBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _blogService;
        private List<Post> _blogPosts;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
            _blogPosts = new List<Post>();
        }


        [HttpGet(Urls.BlogPosts)]
        public IActionResult GetBlogPosts()
        {
            return Ok(_blogService.GetBlogPosts());
        }

        [HttpGet(Urls.BlogPost)]
        public IActionResult GetBlogPostById(int id)
        {
            var blogPost = _blogPosts.SingleOrDefault(x => x.PostID == id);

            if (blogPost == null)
                return NotFound();

            return Ok(blogPost);
        }

        [HttpPost(Urls.AddBlogPost)]
        public IActionResult AddBlogPost([FromBody] Post newBlogPost)
        {
            var savedBlogPost = _blogService.AddBlogPost(newBlogPost);

            return Created(new Uri(Urls.BlogPost.Replace("{id}", savedBlogPost.PostID.ToString()), UriKind.Relative), savedBlogPost);
        }

        [HttpPut(Urls.UpdateBlogPost)]
        public void UpdateBlogPost(int postId, string updatedPost, string updateTitle)
        {
            var originalBlogPost = _blogPosts.Find(x => x.PostID == postId);

            originalBlogPost.Content = updatedPost;
            originalBlogPost.Title = updateTitle;
        }

        [HttpDelete(Urls.DeleteBlogPost)]
        public void DeleteBlogPost(int postId)
        {
            var blogPost = _blogPosts.Find(x => x.PostID == postId);

            _blogPosts.Remove(blogPost);
        }

    }
}