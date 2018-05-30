using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System.Security.Claims;
using System;
using System.Threading.Tasks;
using VisRes.Data.EFCore;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;

namespace VisRes.Service.Api.Core
{
    /// <summary>
    /// JWTBearer
    ///             
    /// DOCO: https://auth0.com/blog/securing-asp-dot-net-core-2-applications-with-jwts/
    /// </summary>
    public static class JwtBearerServiceExtensions
    {
        // http://hamidmosalla.com/2017/10/19/policy-based-authorization-using-asp-net-core-2-and-json-web-token-jwt/

        public static IServiceCollection AddJwtBearerSecurity(this IServiceCollection services, IConfiguration Configuration)
        {
            services

                //===========
                // AddAuthentication
                
                //.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddAuthentication(options => {
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })

                //===========
                // JwtBearer
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,           // validate server that created token
                        ValidateAudience = true,         // ensure recipient of token is authorized to receive it 
                        ValidateLifetime = true,         // check token not expired & signing key of issuer is valid
                        ValidateIssuerSigningKey = true, // verify key used to sign incoming token is part of a list of trusted keys


                        ValidAudience = Configuration["Jwt:Audience"],        // (aud claim)
                        ValidIssuer = Configuration["Jwt:Issuer"],            // (iss claim)

                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SecretKey"])),


                        // https://github.com/Azure-Samples/active-directory-dotnet-webapp-roleclaims/issues/18
                        // https://github.com/IdentityServer/IdentityServer4/issues/1615
                        NameClaimType = "name",
                        RoleClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
                    };


                    //https://joonasw.net/view/adding-custom-claims-aspnet-core-2
                    //Additional config snipped
                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = async ctx =>
                        {
                            //Get the calling app client id that came from the token produced by Azure AD
                            // string clientId = ctx.Principal.FindFirstValue("appid");
                            // https://community.auth0.com/t/how-to-get-the-user-identifier-in-an-asp-net-core-api/6735/2
                            // Check this
                            // https://stackoverflow.com/questions/37694139/get-user-information-from-auth0-using-asp-net-mvc-6-webapi
                            // https://forums.asp.net/t/2130682.aspx?Missing+User+Claims+at+the+ApiController+level
                            // https://stackoverflow.com/questions/42036810/asp-net-core-jwt-mapping-role-claims-to-claimsidentity
                            // https://stackoverflow.com/questions/47043799/net-core-2-jwt-angular-2-authorization-through-roles-does-not-work
                            // https://logcorner.com/token-based-authentication-using-asp-net-web-api-core/
                            string userId = ctx.Principal.FindFirst(ClaimTypes.NameIdentifier).Value;

                            //Get EF context
                            var db = ctx.HttpContext.RequestServices.GetRequiredService<VrsContext>();

                            //Check if this app can read confidential items
                            bool isLiveUser = true; // await db.tblUserSessions.AnyAsync(a => a.UserID == 1); // clientId);
                            if (isLiveUser)
                            {
                                //Add claim if yes
                                var claims = new List<Claim> {
                                    new Claim("LiveUser", "true")
                                };
                                var appIdentity = new ClaimsIdentity(claims);

                                ctx.Principal.AddIdentity(appIdentity);
                            }
                        }
                    };
                });

            return services;
        }

        [Obsolete]
        public static IApplicationBuilder UseAuthenticationSecurity(this IApplicationBuilder app)
        {
            app.UseAuthentication();

            return app;
        }
    }
}