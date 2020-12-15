using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Calabonga.Client.Mvc.Infrastructure.Auth
{
    public class OlderThanRequirementHandler : AuthorizationHandler<OlderThanRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OlderThanRequirement requirement)
        {
            var hasClaim = context.User.HasClaim(x => x.Type == ClaimTypes.DateOfBirth);
            if (!hasClaim)
            {
                return Task.CompletedTask;
            }

            var dateOfBirth = context.User.FindFirst(x => x.Type == ClaimTypes.DateOfBirth).Value;
            var date = DateTime.Parse(dateOfBirth, new CultureInfo("ru-Ru"));
            var canEnterDiff = DateTime.Now.Year - date.Year;

            if (canEnterDiff >= requirement.Years)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
