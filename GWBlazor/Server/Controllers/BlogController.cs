using GWBlazor.Server.Data;
using GWBlazor.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet("GetAllPosts")]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _context.Posts.ToListAsync();
            return Ok(posts);
        }

        [HttpGet("SinglePost/{id}")]
        public async Task<IActionResult> SinglePost(int id)
        {
            var dev = await _context.Posts.FirstOrDefaultAsync(a => a.PostID == id);
            return Ok(dev);
        }
        [HttpPost("AddPost")]
        public async Task<IActionResult> AddPost(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
            return Ok(post.PostID);
        }

        [HttpPut("UpdatePost")]
        public async Task<IActionResult> UpdatePost(Post post)
        {
            _context.Entry(post).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("DeletePost/{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = new Post { PostID = id };
            _context.Remove(post);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
