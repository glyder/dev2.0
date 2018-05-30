using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using VisRes.Data.EFCore;
using VisRes.Models.EF;
using VisRes.Models.Model;

// https://stackoverflow.com/questions/41058142/injecting-dbcontext-into-service-layer

namespace VisRes.Business.Services
{
    public class UserService : IUserService
    {
        private readonly VrsContext _context;

        public UserService(VrsContext context)
        {
            _context = context;
        }


        public async Task<tblUsers> FindByUsername(string username)
        {
            var _tblUsers = await _context.tblUsers
                                          .AsNoTracking()
                                          .SingleOrDefaultAsync(m => m.UserName == username);

            return _tblUsers;
        }

        // TODO: INVESTIGATE default value!!!
        public async Task<int> GetUserId(string username, int defaultValue=1)
        {
            int userId = -1;

            var _tblUsers = await FindByUsername(username);
            userId = (_tblUsers != null) ? _tblUsers.UserID : defaultValue;

            return userId;
        }


        //public async Task<IActionResult> GetById([FromRoute] int id)
        //{
        //    bool
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var tblLob = await _context.tblLOBs.AsNoTracking().SingleOrDefaultAsync(m => m.Lobid == id);

        //    if (tblLob == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(tblLob);
        //}
    }


}
