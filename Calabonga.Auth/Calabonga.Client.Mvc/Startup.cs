using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Calabonga.Client.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(config =>
            {
                config.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                config.DefaultChallengeScheme = "oidc";
            })
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddOpenIdConnect("oidc", config =>
                {
                    config.Authority = "https://localhost:10001";
                    config.ClientId = "client_id_mvc";
                    config.ClientSecret = "client_secret_mvc";
                    config.SaveTokens = true;
                    config.ResponseType = "code";
                    config.GetClaimsFromUserInfoEndpoint = true;
                    config.Scope.Add("OrdersAPI");
                    config.Scope.Add("offline_access");
                    config.GetClaimsFromUserInfoEndpoint = true;
                    //config.ClaimActions.MapAll(); // Маппит все Claims в UserClaim
                    config.ClaimActions.MapJsonKey(ClaimTypes.DateOfBirth, ClaimTypes.DateOfBirth); // Маппит конкретный Claim в UserClaim

                });

            services.AddAuthorization(config =>
            {
                config.AddPolicy("HasDateOfBirth", builder =>
                {
                    builder.RequireClaim(ClaimTypes.DateOfBirth);
                });

                //config.AddPolicy("OlderThan", builder =>
                //{
                //    builder.AddRequirements(new OlderThanRequirement(10));
                //});
            });

            services.AddSingleton<IAuthorizationHandler, OlderThanRequirementHandler>();
            services.AddSingleton<IAuthorizationPolicyProvider, CustomAuthorizationPolicyProvider>();

            services.AddHttpClient();

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }

    public class CustomAuthorizationPolicyProvider : DefaultAuthorizationPolicyProvider
    {
        private readonly AuthorizationOptions options;

        public CustomAuthorizationPolicyProvider(IOptions<AuthorizationOptions> options) : base(options)
        {
            this.options = options.Value;
        }

        public override async Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            var policyExists = await base.GetPolicyAsync(policyName);
            if (policyExists == null)
            {
                policyExists = new AuthorizationPolicyBuilder().AddRequirements(new OlderThanRequirement(10)).Build();
                options.AddPolicy(policyName, policyExists);
            }

            return policyExists;
        }
    }

    public class OlderThanRequirement : IAuthorizationRequirement
    {
        public OlderThanRequirement(int years)
        {
            Years = years;
        }

        public int Years { get; }
    }

    public class OlderThanRequirementHandler : AuthorizationHandler<OlderThanRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OlderThanRequirement requirement)
        {
            var hasClaim = context.User.HasClaim(x => x.Type == ClaimTypes.DateOfBirth);
            if(!hasClaim)
            {
                return Task.CompletedTask;
            }

            var dateOfBirth = context.User.FindFirst(x => x.Type == ClaimTypes.DateOfBirth).Value;
            var date = DateTime.Parse(dateOfBirth, new CultureInfo("ru-Ru"));
            var canEnterDiff = DateTime.Now.Year - date.Year;

            if(canEnterDiff >= requirement.Years)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
