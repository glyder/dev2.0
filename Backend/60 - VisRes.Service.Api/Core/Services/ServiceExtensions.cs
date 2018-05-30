using Microsoft.Extensions.DependencyInjection;

using VisRes.Business.Services;

namespace VisRes.Service.Api.Core.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            // Add all other services here.
            return services;
        }
    }
}
