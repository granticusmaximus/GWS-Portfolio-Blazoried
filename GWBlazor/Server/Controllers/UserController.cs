using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWBlazor.Server.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddRole()
        {
            return View();
        }

        public IActionResult ChangeRole()
        {
            return View();
        }

        public IActionResult DeleteRole()
        {
            return View();
        }
    }
}
