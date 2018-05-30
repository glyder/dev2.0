
using CoreClientLibrary.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using VisRes.Models.Model;

namespace VisRes.Business.Services
{
    public interface IClaimService
    {
        // Task<IActionResult> CreateToken([FromBody]LoginViewModel loginModel);
        Claim[] BuildClaims(UserData userData);
        Task<bool> UserHasAccess(string moduleName, string areaName, string accessName, string userName);
        Task<bool> UserHasArea(string moduleName, string areaName, string userName);
        Task<UserData> GetFullUserData(string loginId, bool clearCache = false);
        Task<ApplicationListUser> GetBasicUserData(string loginId);
    }
}
