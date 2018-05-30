
using System.Security.Claims;
using System.Threading.Tasks;

using CoreClientLibrary.Models;
using VisRes.Data.Repositories;

namespace VisRes.Business.Services
{
    public class ClaimService : IClaimService
    {
        IClaimsUAMRespository _claimsRepository;

        public ClaimService(IClaimsUAMRespository claimsRepository)
        {
            _claimsRepository = claimsRepository;
        }

        public Claim[] BuildClaims(UserData userData)
        {
            return _claimsRepository.BuildClaims(userData);
        }

        /// <summary>
        /// Returns whether or not a user has a particular access
        /// </summary>
        /// <param name="moduleName">The module the access is in</param>
        /// <param name="areaName">The area the module is in</param>
        /// <param name="accessName">The name of the access</param>
        /// <param name="userName">The userName of the user</param>
        /// <returns>bool indicating whether or not the user has the access</returns>
        public async Task<bool> UserHasAccess(string moduleName, string areaName, string accessName, string userName)
        {
            return await _claimsRepository.UserHasAccess(moduleName, areaName, accessName, userName);
        }

        /// <summary>
        /// Returns whether or not a user has any access in a particular area
        /// </summary>
        /// <param name="moduleName">The module the area is in</param>
        /// <param name="areaName">The name the of the area</param>
        /// <param name="userName">The userName of the user</param>
        /// <returns>bool indicating whether or not the user has an access in the area</returns>
        public async Task<bool> UserHasArea(string moduleName, string areaName, string userName)
        {
            return await _claimsRepository.UserHasArea(moduleName, areaName, userName);
        }


        public async Task<UserData> GetFullUserData(string loginId, bool clearCache = false)
        {
            return await _claimsRepository.GetFullUserData(loginId,  clearCache);
        }

        /// <summary>
        /// Returns basic user information. In theory quicker than GetFullUserData
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns>ApplicationListUser with basic info such as full name</returns>
        public async Task<ApplicationListUser> GetBasicUserData(string loginId)
        {
            return await _claimsRepository.GetBasicUserData(loginId);
        }
    }
}
