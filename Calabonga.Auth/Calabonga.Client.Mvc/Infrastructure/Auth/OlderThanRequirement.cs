using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calabonga.Client.Mvc.Infrastructure.Auth
{
    public class OlderThanRequirement : IAuthorizationRequirement
    {
        public OlderThanRequirement(int years)
        {
            Years = years;
        }

        public int Years { get; }
    }
}
