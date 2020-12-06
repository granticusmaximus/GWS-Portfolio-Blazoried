using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GWBlazor.Server.Data;
using GWBlazor.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GWBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private ApplicationDbContext _context;
        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        #region TestBlogs
        private List<Post> _blogPosts { get; set; } = new List<Post> {
            new Post {
                PostID = 1,
                Title = "If only C# worked in the browser",
                Content = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-30)
            },
            new Post {
                PostID = 2,
                Title = "400th JS Framework released",
                Content = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-25)
            },
            new Post {
                PostID = 3,
                Title = "WebAssembly FTW",
                Content = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-20)
            },
            new Post {
                PostID = 4,
                Title = "Blazor is Awesome!",
                Content = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-15)
            },
            new Post {
                PostID = 5,
                Title = "Your first Blazor App",
                Content = "Lorem ipsum dolor sit amet...",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-10)
            },
        };
        #endregion


        // GET: api/<BooksController>
        [HttpGet(Urls.BlogPosts)]
        public IActionResult BlogPosts()
        {
            return Ok(_blogPosts);
        }

        [HttpGet(Urls.BlogPost)]
        public IActionResult GetBlogPostById(int id)
        {
            var blogPost = _blogPosts.SingleOrDefault(x => x.PostID == id);

            if (blogPost == null)
                return NotFound();

            return Ok(blogPost);
        }

        // POST api/<BlogController>
        [HttpPost(Urls.AddPost)]
        public void AddPost([FromBody] Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        // PUT api/<BlohController>
        [HttpPut(Urls.UpdatePost)]
        public void UpdatePost(long id, [FromBody] Post post)
        {
            Post _post = _context.Posts.Where(x => x.PostID.Equals(post.PostID)).FirstOrDefault();
            _post.Title = post.Title;
            _context.SaveChanges();
        }

        // DELETE api/<BooksController>
        [HttpDelete(Urls.DeletePost)]
        public void DeletePost(long id)
        {
            Post _post = _context.Posts.Where(x => x.PostID.Equals(id)).FirstOrDefault();
            _context.Posts.Remove(_post);
            _context.SaveChanges();
        }
    }
}