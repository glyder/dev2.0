using System;

using System.Threading.Tasks;
using System.Net.Http;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

using VisRes.Models.Model;
using CoreClientLibrary;
using CoreClientLibrary.Models;
using System.Security.Claims;

namespace VisRes.Business.Services
{
    // LIVE service --> UAM!
    public class LoginServiceUAM : ILoginService
    {
        protected string responseUAMService;

        private readonly IConfiguration _config;
        private readonly ITokenService _tokenService;
        private readonly IClaimService _claimService;
        private readonly ISessionService _sessionService;
        private readonly IUserService _userService;


        public LoginServiceUAM(IConfiguration config, ITokenService tokenService,
                                IClaimService claimService, ISessionService sessionService,
                                IUserService userService)
        {
            _config = config;
            _tokenService = tokenService;
            _claimService = claimService;
            _sessionService = sessionService;
            _userService = userService;
        }

        public async  Task<JwtModel> GetTokenForUser(LoginViewModel loginModel)
        {
            var authenticateResult = await Authenticate(loginModel);

            if (authenticateResult.UserValidated)
            {
                // Internal users can authenticate via email address but need correct login Id
                loginModel.Username = authenticateResult.LoginId;

                UserData userData = await UAMClientLibrary.GetUserData(loginModel.Username, true);

                JwtModel userJwt = CreateUser(userData);

                // 4. Map Username to get tblUsers.UserID (if 0)
                if (userJwt.UserId == 0)
                {
                    userJwt.UserId = await _userService.GetUserId(loginModel.Username, 0);
                    // If UserId == 0, invalid user????
                }

                // 5a. Add Claims
                Claim[] claims = _claimService.BuildClaims(userData);                   // Build Claims
                userJwt.Token = _tokenService.BuildJwtSecurityToken(userJwt, claims, _config);  // Build JWT (including Claims)

                // 7. Save UserSession (needed for verification of token) 
                //  tblUserSessions mySession = new tblUserSessions() { UserID = userJwt.UserId, SessionAttribute = userJwt.Token };
                // var sessionOkay = _sessionService.SaveSession(userJwt);

               

                return userJwt;
            }
            else
            {
                return new JwtModel() { };
            }
        }

        public async  Task<ValidationResponse> Authenticate(LoginViewModel login)
        {
            return await UAMClientLibrary.ValidateUser(login.Username, login.Password);
        }

        public  JwtModel CreateUser(UserData login)
        {
            JwtModel user = null;

            // SUCCESS (200)! --> return a few items

            string roles = "";
            foreach (var role in login.Roles(UAMClientLibrary.CurrentApplication, UAMClientLibrary.Project))
            {
                if (roles != "")
                {
                    roles += ",";
                }
                roles += role.Name;
            }

            user = new JwtModel
            {
                Username = login.LoginId,                   
                Name = login.FullName,
                Email = login.Email,
               // Birthdate = DateTime.Now.AddYears(-20),
                Roles = roles
            };

            return user;
        }
    }
}
