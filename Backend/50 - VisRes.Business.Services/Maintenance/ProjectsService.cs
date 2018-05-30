using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;

namespace VisRes.Business.Services
{
    public class ProjectsService : IProjectsService
    {
        private readonly VrsContext _context;

        public ProjectsService(VrsContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #region "ALL"

        public async Task<IEnumerable<tblProjects>> GetAll()
        {
            return await _context.tblProjects.AsNoTracking().ToListAsync();
        }

        #endregion

        #region "ByID"

        public async Task<tblProjects> GetByID(int id)
        {
            // return _dapper.GetByID(id);
            return await _context.tblProjects.AsNoTracking()
                                 .SingleOrDefaultAsync(m => m.ProjectID == id);
        }

        #endregion

        public IEnumerable<DropDownListViewModel> Listbox(int? lobID = null)
        {
            IEnumerable<DropDownListViewModel> results = null;

            _context.LoadStoredProc("Projects_Listbox")
                    .WithSqlParam("lobID", lobID)
                    .ExecuteStoredProc((handler) =>
                    {
                        results = handler.ReadToList<DropDownListViewModel>();
                        // do something with your results.
                    });

            return results;
        }

        #region "private members"

        //public bool Exists(int id)
        //{
        //    return _context.tblProjects.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}
