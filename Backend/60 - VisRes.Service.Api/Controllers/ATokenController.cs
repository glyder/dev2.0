using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;

using VisRes.Models.Model;
using VisRes.Models.ViewModels;

using VisRes.Business.Services;
using VisRes.Models.EF;
using CoreClientLibrary.Models;
using CoreClientLibrary;
using VisRes.Service.Api.Core.Infrastructure.Authorisation;

namespace VisRes.Service.Api.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Token")]
    public class ATokenController : Controller
    {
        private IConfiguration _config { get; }
        private IHostingEnvironment _env { get; }       // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-2.1

        private readonly ILoginService _loginService;
   

        public ATokenController(IConfiguration config, IHostingEnvironment env,
                                ILoginService loginService)
        {
            _config = config;
            _env = env;
            _loginService = loginService;
        }

        [AllowAnonymous]  // DO NOT REMOVE!!!
        [HttpPost]
        public async Task<IActionResult> CreateToken([FromBody]LoginViewModel loginModel)
        {
            IActionResult response = Unauthorized();                    // 401 - UnAuthorized immediately

            //TODO: GP, put this eventually into "LoginService" or "TokenService"
            try
            {
                // 1. UAM or Fake?
                //LoginService loginService = new LoginService(_config);       // "Flags:JwtFakeUser"
                                                                             //loginFacade.GetStrategy(LoginStrategyEnum.UAMService);    // Override the loginFacade setting!
               // ILoginService _loginStrategy = _loginService.ILoginService;

                JwtModel userJwt = await _loginService.GetTokenForUser(loginModel);

                response = Ok(new
                {
                    valid = userJwt.Valid,
                    token = userJwt.Token,
                    userName = userJwt.Username,
                    name = userJwt.Name,
                    roles = userJwt.Roles,
                    menu = userJwt.Roles,
                    message = ""
                });

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        #region "Test Authorize"

        [Authorize]
        [HttpGet("TestClaims")]
        public object Claims()
        {
            return User.Claims.Select(c =>
            new
            {
                Type = c.Type,
                Value = c.Value
            });
        }

        // [Authorize(Roles = "admin")]
        [ClaimRequirement("TestModule", "TestArea")]
        [HttpGet("TestAdmin")]
        public string TestAdmin()
        {
            return "You have an access in the TestArea in the TestModule";
        }
       
        [ClaimRequirement("TestModule", "TestArea", "Add a Plant Record to a Company")]
        [HttpGet("TestUser")]
        public string TestUser()
        {
            return "You have the Add a Plant Record to a Company access in the TestArea in the TestModule";
        }

        #endregion
    }

    
}