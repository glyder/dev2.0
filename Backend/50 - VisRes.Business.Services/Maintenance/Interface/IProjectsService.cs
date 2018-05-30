using System.Collections.Generic;
using System.Threading.Tasks;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;

namespace VisRes.Business.Services
{
    public interface IProjectsService
    {
        Task<IEnumerable<tblProjects>> GetAll();

        Task<tblProjects> GetByID(int id);

        IEnumerable<DropDownListViewModel> Listbox(int? lobID = null);

        // bool Exists(int id);
    }
}
