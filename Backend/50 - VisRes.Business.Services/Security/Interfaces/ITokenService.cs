using Microsoft.Extensions.Configuration;

using System.Security.Claims;

using VisRes.Models.Model;

namespace VisRes.Business.Services
{
    public interface ITokenService
    {
        string BuildJwtSecurityToken(JwtModel user, Claim[] claimsUser, IConfiguration _config);
    }
}
