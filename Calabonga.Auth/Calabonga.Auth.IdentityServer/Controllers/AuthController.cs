using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calabonga.Auth.IdentityServer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Calabonga.Auth.IdentityServer.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        [Route("[action]")]
        public IActionResult Login(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
    }
}
