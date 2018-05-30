
using VisRes.Models.Model;

namespace VisRes.Business.Services
{
    public class SessionServiceFake : ISessionService
    {
        public SessionServiceFake() { }

        public bool SaveSession(JwtModel userJwt)
        {
            return true;
        }

        public bool GetSession(int Id)
        {
            return true;
        }
    }
}
