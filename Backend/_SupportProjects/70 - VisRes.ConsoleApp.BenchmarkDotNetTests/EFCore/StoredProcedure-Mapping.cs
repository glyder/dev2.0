using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using BenchmarkDotNet.Attributes;

using VisRes.Data.EFCore;
using VisRes.Models.EF;
using BenchmarkDotNet.Attributes.Jobs;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.Repositories;
using VisRes.Models.ViewModels;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests.EFCore
{
    [SimpleJob(launchCount: 1, warmupCount: 2, targetCount: 5)]
    public class EFCore_StoredProcedure_Mapping
    {
        readonly VrsContext _context;
        DapperRespository _dapper;

        public EFCore_StoredProcedure_Mapping()
        {
            _context = new VrsContext();
            _dapper = new DapperRespository();
        }

        [Benchmark]
        public async Task<IEnumerable<CompanyExpiredInsurancesViewModel>> CompanyExpiredInsurances_DBSet() => await _context.CompanyExpiredInsurancesViewModel.FromSql("Dashboard_ExpiredItems_Company").ToArrayAsync();

        [Benchmark]
        public IEnumerable<CompanyExpiredInsurancesViewModel> CompanyExpiredInsurances_EFExtensions()
        {
            IEnumerable<CompanyExpiredInsurancesViewModel> results = null;

            _context.LoadStoredProc("dbo.Dashboard_ExpiredItems_Company")
                     // .WithSqlParam("fooId", 1)
                     .ExecuteStoredProc((handler) =>
                     {
                         results = handler.ReadToList<CompanyExpiredInsurancesViewModel>();
                         // do something with your results.
                     });

            return results;
        }

        [Benchmark]
        public async Task<IEnumerable<InsuranceTypeNumberExpiredViewModel>> CompanyExpiredInsurances_Dapper()
        {
            return await _dapper.GetCompanyExpiredInsurancesViewModel(null, null, null);
        }

    }
}