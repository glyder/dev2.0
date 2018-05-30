using CoreClientLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using VisRes.Models.Model;

namespace VisRes.Business.Services
{
    public interface ILoginService
    {
        Task<ValidationResponse> Authenticate(LoginViewModel login);
        JwtModel CreateUser(UserData login);
        Task<JwtModel> GetTokenForUser(LoginViewModel loginModel);
    }
}
