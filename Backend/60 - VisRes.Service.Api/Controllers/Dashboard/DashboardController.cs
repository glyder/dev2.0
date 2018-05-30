using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;

using VisRes.Models.EF;
using VisRes.Business.Services;
using VisRes.Models.ViewModels;

namespace VisRes.Service.Api.Controllers.Domain
{
    [Produces("application/json")]
    [Route("api/dashboard")]
    public partial class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [Route("CompanyExpiredInsurances")]
        [HttpGet]
        public async Task<IEnumerable<CompanyExpiredInsurancesViewModel>> CompanyExpiredInsurances_DBSet()
        {
            return await _dashboardService.CompanyExpiredInsurances_DBSet();
        }

        [Route("CompanyExpiredInsurancesEFExtensions")]
        [HttpGet]
        public IEnumerable<InsuranceTypeNumberExpiredViewModel> CompanyExpiredInsurances_EFExtensions()
        {
            return _dashboardService.CompanyExpiredInsurances_EFExtensions();
        }

        [Route("CompanyExpiredInsurancesDapperSP1")]
        [HttpGet]
        public async Task<IEnumerable<InsuranceTypeNumberExpiredViewModel>> CompanyExpiredInsurances_Dapper()
        {
            return await _dashboardService.CompanyExpiredInsurances_Dapper();
        }


    }

}
