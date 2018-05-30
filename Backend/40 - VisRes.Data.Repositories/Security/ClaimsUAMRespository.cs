using CoreClientLibrary;
using CoreClientLibrary.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace VisRes.Data.Repositories
{
    public class ClaimsUAMRespository: IClaimsUAMRespository
    {
        public Claim[] BuildClaims(UserData userData)
        {
            string roles = "";
            foreach (var role in userData.Roles(UAMClientLibrary.CurrentApplication, UAMClientLibrary.Project))
            {
                if (roles != "")
                {
                    roles += ",";
                }
                roles += role.Name;
            }

            List<Claim> claimList = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, userData.UserId.ToString()),
                new Claim("name", userData.LoginId.ToString()),
                new Claim("fullName", userData.FullName),
                new Claim(JwtRegisteredClaimNames.Email, userData.Email),
               // new Claim(JwtRegisteredClaimNames.Birthdate, jwt.Birthdate.ToString("yyyy-MM-dd")),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("roles", roles),

            };

            /*foreach(var project in userData.ProjectsInApplication(UAMClientLibrary.CurrentApplication))
            {
                foreach(var module in project.UsersModules)
                {
                    foreach(var area in module.UserAreas)
                    {
                        foreach(var access in area.Accesses)
                        {
                            claimList.Add(new Claim(module.Name + "||" + area.Name + "||" + access.Name, "1"));
                        }
                    }
                }
            }*/

            return claimList.ToArray();
        }


        public async Task<bool> UserHasAccess(string moduleName, string areaName, string accessName, string userName)
        {
            bool result = await UAMClientLibrary.UserHasAccess(moduleName, areaName, accessName, userName);
            return result;
        }

        public async Task<bool> UserHasArea(string moduleName, string areaName, string userName)
        {
            return await UAMClientLibrary.UserHasArea(moduleName, areaName, userName);
        }

        public async Task<UserData> GetFullUserData(string loginId, bool clearCache = false)
        {
            return await UAMClientLibrary.GetUserData(loginId, clearCache);
        }

        public async Task<ApplicationListUser> GetBasicUserData(string loginId)
        {
            List<ApplicationListUser> allUsers = await UAMClientLibrary.GetApplicationUsers();
            return allUsers.Where(c => string.Equals(c.LoginId, loginId, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }
    }
}
