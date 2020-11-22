using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calabonga.Auth.Orders.Api.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("[action]")]
        public string Secret()
        {
            return "Secret string from Orders API";
        }
    }
}
