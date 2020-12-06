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

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }


        [HttpGet(Urls.BlogPosts)]
        public IActionResult GetBlogPosts()
        {
            return Ok(_blogService.GetBlogPosts());
        }

        [HttpGet(Urls.BlogPost)]
        public IActionResult GetBlogPostById(int id)
        {
            var blogPost = _blogService.GetBlogPost(id);

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
    }
}