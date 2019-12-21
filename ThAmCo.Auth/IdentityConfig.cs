using System;
using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;

namespace ThAmCo.Auth
{
    public static class IdentityConfigurationExtensions
    {
        public static IEnumerable<IdentityResource> GetIdentityResources(this IConfiguration configuration)
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId(),

                new IdentityResources.Profile(),

                new IdentityResource("roles", new[] {"role"}
                                     /*name: "roles",
                                     displayName: "ThAmCo Application Roles",
                                     claimTypes: new [] { "role" }*/)
            };
        }

        public static IEnumerable<ApiResource> GetIdentityApis(this IConfiguration configuration)
        {
            return new ApiResource[]
            {
                new ApiResource("thamco_account_api", "ThAmCo Account Management"),
                new ApiResource("Api_Link","webservice")
                {
                    UserClaims = {"name", "role" }
                }
            };
        }

        public static IEnumerable<Client> GetIdentityClients(this IConfiguration configuration)
        {
            return new Client[]
            {
                new Client
                {
                     ClientId = "Api_Link",
                     ClientName = "Webervice",
                     AllowedGrantTypes = GrantTypes.ClientCredentials,

                     ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                     AllowedScopes=
                    {
                        "thamco_account_api"
                    },

                     RequireConsent = false
                },




               new Client
               {
                   ClientId = "my_web_app",
                    ClientName = "Example Web App",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,

                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes =
                    {
                       IdentityServerConstants.StandardScopes.OpenId, 
                       // allowes crud users
                        "thamco_account_api",
                        //allwoes you to use api
                        "Api_Link",
                        //
                        "openid",
                        "profile",
                        "roles"
                    },

                    RequireConsent = false
                }

            };
        }
    }
}