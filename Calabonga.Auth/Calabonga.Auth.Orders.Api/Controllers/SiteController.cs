using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calabonga.Auth.Orders.Api.Controllers
{
    //[Route("[controller]")]
    //[ApiController]
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
