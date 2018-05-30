using System;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using VisRes.Models.Model;

namespace VisRes.Business.Services
{
    public class TokenService : ITokenService
    {

        public string BuildJwtSecurityToken(JwtModel user, Claim[] claimsUser, IConfiguration _config)
        {
            // TODO: Implement
            // https://auth0.com/blog/securing-asp-dot-net-core-2-applications-with-jwts/

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            int expiryMinutes = int.Parse(_config["Jwt:ExpiryMinutes"]); // 30 (minutes);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                                             _config["Jwt:Audience"],
                                             claimsUser,
                                             expires: DateTime.Now.AddMinutes(expiryMinutes),
                                             signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
