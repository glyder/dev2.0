
using VisRes.Models.EF;

using VisRes.Data.EFCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using System.Linq;

namespace VisRes.Data.Repositories
{
    public interface ILOBsRepository : IEFCoreBaseRepository<tblLOBs> {
        Task<IEnumerable<tblLOBs>> GetAll_SP();             // Extra's
        // public async Task<tblLOBs> GetByID(int id)
        IEnumerable<DropDownListViewModel> Listbox();
    }

    public class LOBsRepository : EFCoreBaseRepository<tblLOBs>, ILOBsRepository
    {
        private VrsContext _context;

        public LOBsRepository(VrsContext context) : base(context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #region "ALL"

        //public async Task<IEnumerable<tblLOBs>> All() { //return await _context.tblLOBs.AsNoTracking().ToListAsync(); }

        public async Task<IEnumerable<tblLOBs>> GetAll_SP()
        {
            return await _context.tblLOBs
                                 .FromSql("Lobs_All")
                                 .ToArrayAsync();

            //return await _northWindDbContext.Products.FromSql("usp_GetProductByName @p0", productName).FirstOrDefaultAsync();
            //await _northWindDbContext.Database.ExecuteSqlCommandAsync("usp_CreateShipper @p0, @p1",
            //        parameters: new[] { "hello", "world" });
        }

        #endregion

        #region "ByID"

        public async Task<tblLOBs> GetByID(int id)
        {
            // return _dapper.GetByID(id);
            //return await _context.tblLOBs.AsNoTracking().SingleOrDefaultAsync(m => m.LOBID == id);
            return await base.GetSingleAsync(m => m.LOBID == id);
        }

        #endregion

        public IEnumerable<DropDownListViewModel> Listbox()
        {
            IEnumerable<DropDownListViewModel> results = null;

            _context.LoadStoredProc("dbo.Lobs_Listbox")
                    .ExecuteStoredProc((handler) =>
                    {
                        results = handler.ReadToList<DropDownListViewModel>();
                        // do something with your results.
                    });

            return results;
        }

        #region "private members"

        private bool Exists(int id)
        {
            return _context.tblLOBs.Any(e => e.LOBID == id);
        }

        #endregion
    }
}

