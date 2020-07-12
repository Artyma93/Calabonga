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

        public async Task<IActionResult> GetOrders()
        {

            var ordersClient = httpClientFactory.CreateClient();

            var response = await ordersClient.GetAsync("https://localhost:5001/site/index");

            var message = await response.Content.ReadAsStringAsync();

            ViewBag.Message = message;
            return View();
        }
    }
}
