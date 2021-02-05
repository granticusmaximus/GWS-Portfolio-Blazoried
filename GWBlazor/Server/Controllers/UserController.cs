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
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        #region Get User Data Area
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.AppUser.ToListAsync();
            return Ok(users);
        }

        [HttpGet("GetSingleUser/{id}")]
        public async Task<IActionResult> GetSingleUser(string id)
        {
            var user = await _context.AppUser.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(ApplicationUser user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user.Id);
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(ApplicationUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = new ApplicationUser { Id = id };
            _context.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        #endregion

        #region Role Data Area
        [HttpPost("AddRole")]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPut("ChangeRole")]
        public IActionResult ChangeRole()
        {
            return View();
        }

        [HttpPut("DeleteRole")]
        public IActionResult DeleteRole()
        {
            return View();
        }
        #endregion
    }
}
