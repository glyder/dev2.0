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
    public class SessionService : ISessionService
    {
        private readonly VrsContext _context;

        public SessionService(VrsContext ctx)
        {
            _context = ctx;
        }

        public bool SaveSession(JwtModel userJwt)
        {
            bool Ok = false;

            if (!_context.tblUserSessions.Any(e => e.UserID == userJwt.UserId &&
                                                   e.SessionAttribute == userJwt.Token))
            {
                try
                {
                    var userID = new SqlParameter("UserID", userJwt.UserId);
                    var sessionAttribute = new SqlParameter("SessionAttribute", userJwt.Token);

                    _context.Database.ExecuteSqlCommand("UserSessions_Insert @p0, @p1",
                                                        parameters: new[] { userJwt.UserId.ToString(),
                                                                            userJwt.Token });
                    _context.SaveChanges();

                    Ok = true;
                }
                catch (DbUpdateException ex)
                {
                    // TODO: Log file but don't worry for now
                    Ok = false;
                }
            }

            return Ok;
        }

        //private bool TblUserSessionExists(int id)
        //{
        //    return _context.tblUserSessions.Any(e => e.UserID == id);
        //}

        public bool GetSession(int Id)
        {
            // var users = from u in _context.tblUserSessions where u.UserID == Id select u;
            // if (users.Count() == 1) { return users.First(); }

            var tblUserSessions = _context.tblUserSessions
                                          .AsNoTracking()
                                          .SingleOrDefault(m => m.UserID == Id);

            return (tblUserSessions == null) ? true : false;
        }

    }


}
