using System;
using System.Threading.Tasks;
using CoreClientLibrary.Models;
using Microsoft.Extensions.Configuration;

using VisRes.Models.Model;

namespace VisRes.Business.Services
{
    // Fake Data - appSetting.json
    public class LoginServiceFake : ILoginService

    {
        private readonly IConfiguration _config;
        private readonly ITokenService _tokenService;
        private readonly IClaimService _claimService;
        private readonly ISessionService _sessionService;
        private readonly IUserService _userService;

        public LoginServiceFake(IConfiguration config, ITokenService tokenService,
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
            return await Task.Run(()=> CreateUser(new UserData()));
        }

        public  Task<ValidationResponse> Authenticate(LoginViewModel login)
        {
            return Task.FromResult(new ValidationResponse() {
                LoginId = login.Username,
                UserValidated = true
            });
        }

        public  JwtModel CreateUser(UserData login)
        {
            JwtModel user = null;

            int _userId = int.Parse(_config["FakeData:UserJwtModel:UserId"]);
            string _name = _config["FakeData:UserJwtModel:Name"];
            string _email = _config["FakeData:UserJwtModel:Email"];
            string _birth = _config["FakeData:UserJwtModel:Birthdate"];
            string _roles = _config["FakeData:UserJwtModel:Roles"];

            DateTime _birthdate = DateTime.ParseExact(_birth, "dd/MM/yyyy hh:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);

            user = new JwtModel {
                Valid = true,
                UserId = _userId,
                Name = _name,
                Email = _email,
                Birthdate = _birthdate,

                Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJHYXJ5IEFibGV0dCBKdW5pb3IiLCJlbWFpbCI6ImdhcnlAYWZsLmNvbS5hdSIsImJpcnRoZGF0ZSI6IjE5OTItMTItMjUiLCJqdGkiOiJjYTFjY2Q1MS02MzI5LTRlYWItOGM3Mi1kM2E0YjBmNWNmNGIiLCJleHAiOjE1MjUzMjkwNjksImlzcyI6Imh0dHA6Ly92aXNpb25zdHJlYW0uY29tLmF1IiwiYXVkIjoiaHR0cDovL3Zpc2lvbnN0cmVhbS5jb20uYXUifQ.dNT0_s7smjjub6oQM8-ycuvUcSWRHjQiJw44YUK1v_w",
                Roles = _roles
            };

            return user;
        }

    }
}
