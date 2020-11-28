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

        // GET: api/<BooksController>
        [HttpGet("Blog")]
        public object GetAllBlogs()
        {
            return new { Items = _context.Blogs, Count = _context.Blogs.Count() };
        }

        // POST api/<BlogController>
        [HttpPost("AddBlog")]
        public void AddBlog([FromBody] Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }

        // PUT api/<BlohController>
        [HttpPut]
        public void UpdateBlog(long id, [FromBody] Blog blog)
        {
            Blog _blog = _context.Blogs.Where(x => x.BlogID.Equals(blog.BlogID)).FirstOrDefault();
            _blog.Title = blog.Title;
            _context.SaveChanges();
        }

        // DELETE api/<BooksController>
        [HttpDelete("{id}")]
        public void DeleteBlog(long id)
        {
            Blog _book = _context.Blogs.Where(x => x.BlogID.Equals(id)).FirstOrDefault();
            _context.Blogs.Remove(_book);
            _context.SaveChanges();
        }
    }
}