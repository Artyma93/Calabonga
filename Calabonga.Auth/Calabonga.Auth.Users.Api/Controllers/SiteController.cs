using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calabonga.Auth.Users.Api.Controllers
{
    public class SiteController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public SiteController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetOrders()
        {
            ViewBag.Message = "Test";
            return View();
        }
    }
}
