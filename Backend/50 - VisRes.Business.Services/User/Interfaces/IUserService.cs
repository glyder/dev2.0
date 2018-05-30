using System.Threading.Tasks;

using VisRes.Models.EF;

namespace VisRes.Business.Services
{
    public interface IUserService
    {
        // UserInfo
        Task<tblUsers> FindByUsername(string username);
        Task<int> GetUserId(string username, int defaultValue = 1);
    }
}
