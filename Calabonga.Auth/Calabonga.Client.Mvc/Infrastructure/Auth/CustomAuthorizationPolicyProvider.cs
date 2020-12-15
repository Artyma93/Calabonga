using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calabonga.Client.Mvc.Infrastructure.Auth
{
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
}
