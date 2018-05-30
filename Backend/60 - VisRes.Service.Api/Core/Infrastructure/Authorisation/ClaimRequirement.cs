using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Threading.Tasks;
using VisRes.Business.Services;

namespace VisRes.Service.Api.Core.Infrastructure.Authorisation
{
    public class UAMClaimObject
    {
        public UAMClaimObject(string moduleName, string areaName)
        {
            ModuleName = moduleName;
            AreaName = areaName;
        }

        public UAMClaimObject(string moduleName, string areaName, string accessName)
        {
            ModuleName = moduleName;
            AreaName = areaName;
            AccessName = accessName;
        }
        public string ModuleName { get; set; } = "";
        public string AreaName { get; set; } = "";
        public string AccessName { get; set; } = "";
    }

    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(string moduleName, string areaName) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new UAMClaimObject(moduleName, areaName) };
        }

        public ClaimRequirementAttribute(string moduleName, string areaName, string accessName) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new UAMClaimObject(moduleName, areaName, accessName) };
        }
    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly UAMClaimObject _claim;
        readonly IClaimService _claimService;

        public ClaimRequirementFilter(IClaimService claimService, UAMClaimObject claim)
        {
            _claim = claim;
            _claimService = claimService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string userName = context.HttpContext.User.Identity.Name;
            if (userName == "")
            {
                context.Result = new ForbidResult();
            }
            else
            {
                if (_claim.AccessName != "" && _claimService.UserHasAccess(_claim.ModuleName, _claim.AreaName, _claim.AccessName, userName).Result == false)
                {
                    context.Result = new ForbidResult();
                }
                else if(_claimService.UserHasArea(_claim.ModuleName, _claim.AreaName,  userName).Result == false)
                {
                    context.Result = new ForbidResult();
                }
            }
            
        }
    }
}
