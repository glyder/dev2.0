using System.Threading.Tasks;

using VisRes.Models.EF;
using VisRes.Models.Model;

// https://stackoverflow.com/questions/41058142/injecting-dbcontext-into-service-layer

namespace VisRes.Business.Services
{
    public class UserServiceFake : IUserService
    {
        public UserServiceFake() { }

        public async Task<tblUsers> FindByUsername(string username)
        {
            var _tblUsers = new tblUsers
            {
                UserName = "Gary Ablet",
                // Continue here with other properties.
            };

            return await Task.FromResult(_tblUsers);
        }

        public async Task<int> GetUserId(string username, int defaultValue=1)
        {
            return await Task.FromResult(defaultValue); 
        }
    }


}
