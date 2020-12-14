using Calabonga.Client.Mvc.ViewModels;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", model.AccessToken);

                client.SetBearerToken(model.AccessToken);

                var stringAsync = await client.GetStringAsync("https://localhost:5001/site/secret");

                await RefreshToken(model.RefreshToken);

                ViewBag.Message = stringAsync;

            }
            catch (Exception exception)
            {
                ViewBag.Message = exception.Message;
            }

            return View(model);
        }

        private async Task RefreshToken(string refreshToken)
        {
            var refreshClient = httpCLientFactory.CreateClient();

            var parameters = new Dictionary<string, string>
            {
                ["refresh_token"] = refreshToken,
                ["grant_type"] = "refresh_token",
                ["client_id"] = "client_id_mvc",
                ["client_secret"] = "client_secret_mvc",
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:10001/connect/token")
            {
                Content = new FormUrlEncodedContent(parameters)
            };

            var basics = "client_id_mvc:client_secret_mvc";

            var encodedData = Encoding.UTF8.GetBytes(basics);

            var encodeData64Base = Convert.ToBase64String(encodedData);

            request.Headers.Add("Authorization", $"Bearer {encodeData64Base}");

            var response = await refreshClient.SendAsync(request);

            var tokenData = await response.Content.ReadAsStringAsync();

            var tokenResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(tokenData);

            var accessTokenNew = tokenResponse.GetValueOrDefault("access_token");
            var refreshTokenNew = tokenResponse.GetValueOrDefault("refresh_token");

            await UpdateAuthContextAsync(accessTokenNew, refreshToken);

            //return Task.CompletedTask;
        }

        private async Task UpdateAuthContextAsync(string accessTokenNew, string refreshToken)
        {
            var authenticate = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            authenticate.Properties.UpdateTokenValue("access_token", accessTokenNew);
            authenticate.Properties.UpdateTokenValue("refresh_token", refreshToken);

            await HttpContext.SignInAsync(authenticate.Principal, authenticate.Properties);
        }

        [Authorize(Policy = "HasDateOfBirth")]
        [Route("[action]")]
        public IActionResult Secret1()
        {
            var model = new ClaimManager(HttpContext, User);

            return View("Secret", model);
        }

        [Authorize(Policy = "OlderThan")]
        [Route("[action]")]
        public IActionResult Secret2()
        {
            var model = new ClaimManager(HttpContext, User);

            return View("Secret", model);
        }
    }
}
