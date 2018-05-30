using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisRes.Models.EF;
using VisRes.Models.ViewModels;

namespace VisRes.Business.Services
{
    public interface IDashboardService
    {
        [Obsolete]
        Task<IEnumerable<CompanyExpiredInsurancesViewModel>> CompanyExpiredInsurances_DBSet(int? lobID = null,       // EF Core 2.0 interface
                                                                                            int? projectID = null,
                                                                                            int? companyID = null);
        IEnumerable<InsuranceTypeNumberExpiredViewModel> CompanyExpiredInsurances_EFExtensions(int? lobID = null,      // ViewModel interface
                                                                                             int? projectID = null,
                                                                                             int? companyID = null);
        Task<IEnumerable<InsuranceTypeNumberExpiredViewModel>> CompanyExpiredInsurances_Dapper(int? lobID = null,
                                                                                             int? projectID = null,
                                                                                             int? companyID = null);
    }
}
