using Calabonga.Client.Mvc.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Calabonga.Client.Mvc.Controllers
{
    [Route("[controller]")]
    public class SiteController : Controller
    {
        private readonly IHttpClientFactory httpCLientFactory;

        public SiteController(IHttpClientFactory httpCLientFactory)
        {
            this.httpCLientFactory = httpCLientFactory;
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("[action]")]
        public async Task<IActionResult> Secret()
        {
            var model = new ClaimManager(HttpContext, User);

            try
            {

                var client = httpCLientFactory.CreateClient();

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", model.AccessToken);

                var stringAsync = await client.GetStringAsync("https://localhost:5001/site/secret");

                ViewBag.Message = stringAsync;

            }
            catch (Exception exception)
            {
                ViewBag.Message = exception.Message;
            }

            return View(model);
        }
    }
}
