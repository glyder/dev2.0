using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;
using VisRes.Data.Repositories;

namespace VisRes.Business.Services
{
    public interface ILOBsService
    {
        Task<IEnumerable<tblLOBs>> GetAll();
        Task<IEnumerable<tblLOBs>> GetAll_SP();

        Task<tblLOBs> GetByID(int id);

        IEnumerable<DropDownListViewModel> Listbox();
    }

    public class LOBsService : ILOBsService
    {
        private readonly ILOBsRepository _lobsRepository;

        public LOBsService(ILOBsRepository lobsRepository)
        {
            _lobsRepository = lobsRepository;
        }

        #region "Get ALL"

        public async Task<IEnumerable<tblLOBs>> GetAll()
        {
            return await _lobsRepository.GetAllAsync();                      // pre-build repository
            // return await _context.tblLOBs.AsNoTracking().ToListAsync();      // old EF CORE
        }

        public async Task<IEnumerable<tblLOBs>> GetAll_SP()
        {
            return await _lobsRepository.GetAll_SP();
            // return await _context.tblLOBs.AsNoTracking().ToListAsync();      // old EF CORE
        }

        #endregion

        #region "GetByID"

        public async Task<tblLOBs> GetByID(int id)
        {
            // return _dapper.GetByID(id);
            //return await _context.tblLOBs.AsNoTracking().SingleOrDefaultAsync(m => m.LOBID == id);
            return await _lobsRepository.GetSingleAsync(m => m.LOBID == id);
        }

        #endregion

        #region "Custom methods - listbox"

        public IEnumerable<DropDownListViewModel> Listbox()
        {
            return _lobsRepository.Listbox();
        }

        #endregion
    }
}
