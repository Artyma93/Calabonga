using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Calabonga.Client.Mvc.ViewModels
{
    public class ClaimViewer
    {
        public ClaimViewer(string name, IEnumerable<Claim> claims)
        {
            if (claims == null) throw new ArgumentNullException(nameof(claims));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Claims = claims.ToList();
            Token = "N/A";
        }

        public ClaimViewer(string name, string tokenJson, bool skipParsing = false)
        {
            //if (tokenJson == null) throw new ArgumentNullException(nameof(tokenJson));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            
            if (!skipParsing)
            {
                Claims = ((JwtSecurityToken)new JwtSecurityTokenHandler().ReadToken(tokenJson)).Claims?.ToList();
            }

            Token = tokenJson;
        }

        public List<Claim> Claims { get; }

        public string Name { get; }

        public string Token { get; }
    }
}
