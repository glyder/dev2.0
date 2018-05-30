using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;

namespace VisRes.Business.Services
{
    public class ProjectsServiceFake : BASEServiceFake, IProjectsService
    {
        public ProjectsServiceFake()
        {
            // _context = GetContextWithData();     // IN BASE!
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
            var mock = new List<DropDownListViewModel>();
            mock.Add(new DropDownListViewModel { Value = 27, Text = "000827 - Visionstream Ops NSW" });
            mock.Add(new DropDownListViewModel { Value = 35, Text = "000833 - TELSTRADIUS" });
            mock.Add(new DropDownListViewModel { Value = 264, Text = "034122 - ENERGEX - OVERHEAD WIRES" });
            mock.Add(new DropDownListViewModel { Value = 244, Text = "110310 - FSDNSW" });
            mock.Add(new DropDownListViewModel { Value = 318, Text = "200200 - TRANSGRID" });

            return mock;
        }

        #region "private members"

        //public bool Exists(int id)
        //{
        //    return _context.tblProjects.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}
