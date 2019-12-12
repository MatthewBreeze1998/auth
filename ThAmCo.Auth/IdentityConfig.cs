using System;
using System.Collections.Generic;
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

                new IdentityResource(name: "roles",
                                     displayName: "ThAmCo Application Roles",
                                     claimTypes: new [] { "role" })
            };
        }

        public static IEnumerable<ApiResource> GetIdentityApis(this IConfiguration configuration)
        {
            return new ApiResource[]
            {
                new ApiResource("ReSaleApi", "ThAmCo Account Management"),
                new ApiResource("ReSaleApi","webservice")
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
                     ClientId = "ReSaleApi",
                     ClientName = "ReSaleWebervice",
                     AllowedGrantTypes = GrantTypes.ClientCredentials,

                     ClientSecrets =
                    {
                        new Secret("secrect".Sha256())
                    },

                     AllowedScopes=
                    {
                        "ReSaleApi"
                    },

                     RequireConsent = false
                },
                


                // this is for webservices 
               /*new Client
               {
                   ClientId = "",
                    ClientName = "",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,

                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    
                    AllowedScopes =
                    {
                        // allowes crud users
                        "thamco_acount_api",
                        //allwoes you to use api
                        "ReSaleAPI",
                        //
                        "openid",
                        "profile",
                        "roles"
                    },
                
                    RequireConsent = false
                }*/
            
            };
        }
    }
}
