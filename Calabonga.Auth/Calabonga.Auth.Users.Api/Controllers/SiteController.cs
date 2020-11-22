using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;

namespace Calabonga.Auth.Users.Api.Controllers
{
    [Route("[controller]")]
    public class SiteController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public SiteController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public async Task<IActionResult> GetOrders()
        {
            // retrieve to Identity
            var authClient = httpClientFactory.CreateClient();

            var discoveryDocument = await authClient.GetDiscoveryDocumentAsync("https://localhost:10001");

            var tokenResponse = await authClient.RequestClientCredentialsTokenAsync(
                new ClientCredentialsTokenRequest
                {
                    Address = discoveryDocument.TokenEndpoint,

                    ClientId = "client_id",
                    ClientSecret = "client_secret",

                    Scope = "OrdersAPI"
                });

            // retrieve to Orders
            var ordersClient = httpClientFactory.CreateClient();

            ordersClient.SetBearerToken(tokenResponse.AccessToken);

            var response = await ordersClient.GetAsync("https://localhost:5001/site/secret");

            if (!response.IsSuccessStatusCode)
            {
                ViewBag.Message = response.StatusCode.ToString();
                return View();
            }

            var message = await response.Content.ReadAsStringAsync();

            ViewBag.Message = message;
            return View();
        }
    }
}
