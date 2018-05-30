using CoreClientLibrary.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace VisRes.Data.Repositories
{
    public interface IClaimsUAMRespository
    {
        Claim[] BuildClaims(UserData userData);
        Task<bool> UserHasAccess(string moduleName, string areaName, string accessName, string userName);
        Task<bool> UserHasArea(string moduleName, string areaName, string userName);
        Task<UserData> GetFullUserData(string loginId, bool clearCache = false);
        Task<ApplicationListUser> GetBasicUserData(string loginId);
    }
}
