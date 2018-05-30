using System.Collections.Generic;                                                      
using Microsoft.AspNetCore.Mvc;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;

using VisRes.Business.Services;

namespace VisRes.Service.Api.Controllers.Domain
{
    [Produces("application/json")]
    [Route("api/dashboard")]
    public class DashboardExpiredItemsController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardExpiredItemsController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }


        ////[Route("expired-items/company")]
        //[Route("expired-items/individual")]
        //[HttpGet]
        //public int Test1() {
        //    return 1;
        //}

        [Route("expired-items/company/expired-insurances")]
        [HttpGet]
        public IEnumerable<InsuranceTypeNumberExpiredViewModel> CompanyExpiredInsurances(int? lobID = null,
                                                                                         int? projectID = null,
                                                                                         int? companyID = null)
        {
            var currentUser = HttpContext.User;

            return  _dashboardService.CompanyExpiredInsurances_EFExtensions(lobID, projectID, companyID);

            //var insuranceStatsBookList = new InsuranceTypeNumberExpiredViewModel[] {
            //new InsuranceTypeNumberExpiredViewModel { InsuranceType = "All Insurances", NumberExpired = 2954 },
            //    new InsuranceTypeNumberExpiredViewModel { InsuranceType = "Workcover (or equivalent)", NumberExpired = 355 },
            //    new InsuranceTypeNumberExpiredViewModel { InsuranceType = "Public Liability", NumberExpired = 111 },
            //    new InsuranceTypeNumberExpiredViewModel { InsuranceType = "Professional Indemnity", NumberExpired = 537 },
            //    new InsuranceTypeNumberExpiredViewModel { InsuranceType = "Works Insurance", NumberExpired = 473 }
            //};

            //return insuranceStatsBookList;
        }

        [Route("expired-items/company/insurance-due")]
        [HttpGet]
        public IEnumerable<InsuranceTypeNumberExpiredViewModel> CompanyInsuranceDue(int? lobID = null,
                                                                                    int? projectID = null,
                                                                                    int? companyID = null)
        {
            var currentUser = HttpContext.User;

            var insuranceStatsBookList = new InsuranceTypeNumberExpiredViewModel[] {
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="All Insurances", NumberExpired=412},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Workcover (or equivalent)", NumberExpired=74},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Public Liability", NumberExpired=162},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Professional Indemnity", NumberExpired=26},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Works Insurance", NumberExpired=4}
            };

            return insuranceStatsBookList;
        }

        [Route("expired-items/individual")]
        [HttpGet]
        public IEnumerable<InsuranceTypeNumberExpiredViewModel> Individual(int? lobID = null,
                                                                           int? projectID = null,
                                                                           int? companyID = null)
        {
            var currentUser = HttpContext.User;

            var insuranceStatsBookList = new InsuranceTypeNumberExpiredViewModel[] {
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="All Insurances", NumberExpired=69},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Workcover (or equivalent)", NumberExpired=17},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Public Liability", NumberExpired=20},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Professional Indemnity", NumberExpired=2},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Works Insurance", NumberExpired=3}
            };

            return insuranceStatsBookList;
        }

        [Route("expired-items/contract")]
        [HttpGet]
        public IEnumerable<InsuranceTypeNumberExpiredViewModel> Contract(int? lobID = null,
                                                                         int? projectID = null,
                                                                         int? companyID = null)
        {
            var currentUser = HttpContext.User;

            var insuranceStatsBookList = new InsuranceTypeNumberExpiredViewModel[] {
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="All Insurances", NumberExpired=33},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Workcover (or equivalent)", NumberExpired=23},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Public Liability", NumberExpired=14},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Professional Indemnity", NumberExpired=7},
                new InsuranceTypeNumberExpiredViewModel { InsuranceType="Works Insurance", NumberExpired=2}
            };

            return insuranceStatsBookList;
        }


    }

}
