using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;
using System.Linq;

namespace VisRes.Business.Services
{
    public interface IIndividualsService
    {
        Task<IEnumerable<tblIndividuals>> GetAll();
        Task<IPagedList<tblIndividuals>> GetAllPaged(int pageIndex = 0, int pageSize = 100);
        Task<IEnumerable<tblIndividuals>> GetAll_SP();

        Task<tblIndividuals> GetByID(int id);

        IEnumerable<DropDownListViewModel> Listbox(int? lobID = null,
                                                   int? projectID = null,
                                                   int? companyID = null);

        // bool Exists(int id);
    }

    public class IndividualsService : IIndividualsService
    {
        private readonly VrsContext _context;

        public IndividualsService(VrsContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #region "ALL"

        public async Task<IEnumerable<tblIndividuals>> GetAll()
        {
            return await _context.tblIndividuals.AsNoTracking().ToListAsync();
        }

        public async Task<IPagedList<tblIndividuals>> GetAllPaged(int pageIndex=0, int pageSize=100)
        {
            return await _context.tblIndividuals.AsNoTracking().ToPagedListAsync(pageIndex, pageSize);
        }

        public async Task<IEnumerable<tblIndividuals>> GetAll_SP()
        {
            return await _context.tblIndividuals
                                 .FromSql("Individuals_All")
                                 .ToArrayAsync();
        }

        #endregion

        #region "ByID"

        public async Task<tblIndividuals> GetByID(int id)
        {
            // return _dapper.GetByID(id);
            return await _context.tblIndividuals.AsNoTracking().SingleOrDefaultAsync(m => m.IndividualID == id);
        }

        #endregion

        #region "public methods"

        public IEnumerable<DropDownListViewModel> Listbox(int? lobID = null,
                                                          int? projectID = null,
                                                          int? companyID = null)
        {
            IEnumerable<DropDownListViewModel> results = null;

            _context.LoadStoredProc("dbo.Individuals_Listbox")
                    .WithSqlParam("lobID", lobID)
                    .WithSqlParam("projectID", projectID)
                    .WithSqlParam("companyID", companyID)
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

        #endregion

        #region "private members"

        //public bool Exists(int id)
        //{
        //    return _context.tblIndividuals.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}
