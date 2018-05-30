using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;


namespace VisRes.Business.Services
{
    public interface ICompaniesService
    {
        Task<IEnumerable<tblCompanies>> GetAll();
        Task<IEnumerable<tblCompanies>> GetAll_SP();

        Task<tblCompanies> GetByID(int id);

        IEnumerable<DropDownListViewModel> Listbox(int? lobID=null, int? projectID=null);

        // bool Exists(int id);
    }

    public class CompaniesService : ICompaniesService
    {
        private readonly VrsContext _context;

        public CompaniesService(VrsContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #region "ALL"

        public async Task<IEnumerable<tblCompanies>> GetAll()
        {
            return await _context.tblCompanies.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<tblCompanies>> GetAll_SP()
        {
            return await _context.tblCompanies
                                 .FromSql("Companies_All")
                                 .ToArrayAsync();

            //return await _northWindDbContext.Products.FromSql("usp_GetProductByName @p0", productName).FirstOrDefaultAsync();
            //await _northWindDbContext.Database.ExecuteSqlCommandAsync("usp_CreateShipper @p0, @p1",
            //        parameters: new[] { "hello", "world" });
        }

        #endregion

        #region "ByID"

        public async Task<tblCompanies> GetByID(int id)
        {
            // return _dapper.GetByID(id);
            return await _context.tblCompanies.AsNoTracking().SingleOrDefaultAsync(m => m.CompanyID == id);
        }

        #endregion

        public IEnumerable<DropDownListViewModel> Listbox(int? lobID = null, 
                                                          int? projectID = null)
        {
            IEnumerable<DropDownListViewModel> results = null;

            _context.LoadStoredProc("dbo.Companies_Listbox")
                    .WithSqlParam("lobID", lobID)
                    .WithSqlParam("projectID", projectID)
                    .ExecuteStoredProc((handler) =>
                    {
                        results = handler.ReadToList<DropDownListViewModel>();
                        // do something with your results.
                    });

            //var mock = new List<DropDownListViewModel>();
            //mock.Add(new DropDownListViewModel { Value = 27, Text = "000827 - Visionstream Ops NSW" });
            //mock.Add(new DropDownListViewModel { Value = 35, Text = "000833 - TELSTRADIUS" });
            //mock.Add(new DropDownListViewModel { Value = 264, Text = "034122 - ENERGEX - OVERHEAD WIRES" });
            //mock.Add(new DropDownListViewModel { Value = 244, Text = "110310 - FSDNSW" });
            //mock.Add(new DropDownListViewModel { Value = 318, Text = "200200 - TRANSGRID" });

            //return mock;

            return results;
        }

        #region "private members"

        //public bool Exists(int id)
        //{
        //    return _context.tblCompanies.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}
