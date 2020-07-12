using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calabonga.Auth.IdentityServer
{
    public static class Configuration
    {

        public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
        {
            new ApiScope("OrdersAPI", "OrdersAPI")
        };

        public static IEnumerable<Client> GetClients() =>
        new List<Client>
        {
                    new Client
                    {
                        ClientId = "client_id",
                        ClientSecrets = {new Secret("client_secret".Sha256())},

                        AllowedGrantTypes = GrantTypes.ClientCredentials,

                        AllowedScopes =
                        {
                            "OrdersAPI"
                        }
                    }
        };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>
            {
                new ApiResource("OrdersAPI")
            };

        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId()
            };
    }
}
