using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;
using System;
using System.Linq;

namespace VisRes.Business.Services
{
    public class LOBsServiceFake : BASEServiceFake, ILOBsService
    {
        public LOBsServiceFake()
        {
            // _context = GetContextWithData();     // IN BASE!
        }

        #region "ALL"

        public async Task<IEnumerable<tblLOBs>> GetAll()
        {
            return await _context.tblLOBs.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<tblLOBs>> GetAll_SP()
        {
            return await _context.tblLOBs.AsNoTracking().ToListAsync();
        }

        #endregion

        #region "ByID"

        public async Task<tblLOBs> GetByID(int id)
        {
            // return _dapper.GetByID(id);
            return await _context.tblLOBs.AsNoTracking()
                                 .SingleOrDefaultAsync(m => m.LOBID == id);
        }

        #endregion

        public IEnumerable<DropDownListViewModel> Listbox()
        {
            // https://stackoverflow.com/questions/2420744/linq-to-sql-custom-object-with-listt-property
            // https://stormpath.com/blog/tutorial-entity-framework-core-in-memory-database-asp-net-core
            var response = _context.tblLOBs.Select(u => new DropDownListViewModel
            {
                Value = u.LOBID,
                Text = u.LOB,
            });

            return response;

            //var mock = new List<SelectViewModel>();
            //mock.Add(new SelectViewModel { Value = 1, Text = "VIC" });
            //mock.Add(new SelectViewModel { Value = 2, Text = "NSW" });
            //mock.Add(new SelectViewModel { Value = 3, Text = "SA" });
            //mock.Add(new SelectViewModel { Value = 4, Text = "QLD" });
            //mock.Add(new SelectViewModel { Value = 5, Text = "TAS" });
            //mock.Add(new SelectViewModel { Value = 6, Text = "NATIONAL" });

            //return mock;
        }

        #region "private members"

        //public bool Exists(int id)
        //{
        //    return _context.tblLOBs.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}
