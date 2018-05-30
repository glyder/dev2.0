using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

using VisRes.Models.EF;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;
using VisRes.Data.Repositories;
using VisRes.Models.ViewModels;
using System;

namespace VisRes.Business.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly VrsContext _context;
        private readonly DapperRespository _dapperRepository;

        public DashboardService(VrsContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            _dapperRepository = new DapperRespository();
        }

        // 
        // Expired Items - Company (through EF CORE - EF MODEL MUST EXIST - waiting for EF Core 2.1)
        [Obsolete]
        public async Task<IEnumerable<CompanyExpiredInsurancesViewModel>> CompanyExpiredInsurances_DBSet(int? lobID = null,
                                                                                                         int? projectID = null,
                                                                                                         int? companyID = null)
        {
            // DO NOT USE (WAITING) --> USE LoadStoredProc below
            return await _context.CompanyExpiredInsurancesViewModel
                                 .FromSql("Dashboard_ExpiredItems_CompanyExpiredInsurance")
                                 .ToArrayAsync();
        }

        // Expired Items - 1
        public IEnumerable<InsuranceTypeNumberExpiredViewModel> CompanyExpiredInsurances_EFExtensions(int? lobID = null,
                                                                                                      int? projectID = null,
                                                                                                      int? companyID = null)
        {
            IEnumerable<InsuranceTypeNumberExpiredViewModel> results = null;

            if (lobID == 0) lobID = null;
            if (projectID == 0) projectID = null;
            if (companyID == 0) companyID = null;

            _context.LoadStoredProc("dbo.Dashboard_ExpiredItems_CompanyExpiredInsurance")

                    .WithSqlParam("lobID", lobID)
                    .WithSqlParam("projectID", projectID)
                    .WithSqlParam("companyID", companyID)

                    .ExecuteStoredProc((handler) =>
                    {
                        results = handler.ReadToList<InsuranceTypeNumberExpiredViewModel>();
                        // do something with your results.
                    });

            return results;
        }

        public async Task<IEnumerable<InsuranceTypeNumberExpiredViewModel>> CompanyExpiredInsurances_Dapper(int? lobID = null,
                                                                                                            int? projectID = null,
                                                                                                            int? companyID = null)
        {
            return await _dapperRepository.GetCompanyExpiredInsurancesViewModel(lobID, projectID, companyID);
        }
    }
}
