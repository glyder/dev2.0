using Microsoft.Extensions.DependencyInjection;
using VisRes.Business.Services;

namespace VisRes.Service.Api.Core
{
    public static class ServicesRegisterExtensions
    {
        public static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            // services.AddTransient<IUserService, UserService>();
            // Add all other services here.

            return services;
        }
    }
}
