
using VisRes.Models.Model;

namespace VisRes.Business.Services
{
    public interface ISessionService
    {
        // Sessions
        bool SaveSession(JwtModel userJwt);
        bool GetSession(int userId);
    }
}
