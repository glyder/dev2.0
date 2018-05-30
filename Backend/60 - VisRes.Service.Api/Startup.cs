using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

// EF Core 2.0
using Microsoft.EntityFrameworkCore;
using VisRes.Data.EFCore;



// Jwt
// ASP.NET Core 2.0 - No longer need to install external packages as JSON Web Tokens are natively supported.
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using VisRes.Service.Api.Core;
using System.Security.Claims;
using VisRes.Business.Services;
using CoreClientLibrary;

using VisRes.Data.Repositories;

namespace VisRes.Service.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        //private static DbContextOptions _contextOptions;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #region "1. AddMvc() - CONFIGURE HERE"

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region "Add - EF Core 2.0"

            services.AddDbContext<VrsContext>(options => options.UseSqlServer(
                 // Configuration.GetConnectionString("DefaultConnection")
                 // "Data Source=VS28MVAPPSQL1-t;Initial Catalog=VisResTwo;Integrated Security=True"
                  "Data Source=TST-VM-VRSQL1;Initial Catalog=VisRes2;User ID=VisResWeb;Password=Sayvn1Derz03:23"
                  // "Data Source=.\\SQLEXPRESS;Initial Catalog=VisRes2;Integrated Security=True;MultipleActiveResultSets=True"
                ));
            //services.AddDbContext<VrsContext>(options => options.UseInMemoryDatabase("vrs"));

            #endregion

            #region "Add - Register Services - ie. AddTransient(IUserService...)"

            //services.AddRegisterServices();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IClaimService, ClaimService>();

            //services.AddTransient<ISessionService, SessionService>();
            services.AddTransient<ISessionService, SessionServiceFake>();
            //services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserService, UserServiceFake>();

            services.AddTransient<IClaimsUAMRespository, ClaimsUAMRespository>();
            if (bool.Parse(Configuration["Flags:JwtFakeUser"]))
            {
                services.AddTransient<ILoginService, LoginServiceFake>();
            }
            else
            {
                services.AddTransient<ILoginService, LoginServiceUAM>();
            }

            services.AddTransient<ILOBsRepository, LOBsRepository>();
            services.AddTransient<ILOBsService, LOBsService>();           
            //services.AddTransient<ILOBsService, LOBsServiceFake>();
            services.AddTransient<ICompaniesService, CompaniesService>();
            //services.AddTransient<ICompaniesService, CompaniesServiceFake>();
            services.AddTransient<IIndividualsService, IndividualsService>();
            //services.AddTransient<IIndividualsService, IndividualsServiceFake>();
            services.AddTransient<IProjectsService, ProjectsService>();
            //services.AddTransient<IProjectsService, ProjectsServiceFake>();

            services.AddTransient<IDashboardService, DashboardService>();


            #endregion

            #region "Add - Swagger"

            services.AddSwaggerDocumentation();             // Service Extensions
            
            #endregion

            #region "Add - CORS"

            services.AddCors();
            services.AddCors(cors =>
            {
                cors.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
                                                                .AllowAnyMethod()
                                                                .AllowAnyHeader()
                                                                .AllowCredentials());
            });

            #endregion

            #region "Add - JWT - AddAuthentication - JwtBearerSecurity"

            services.AddJwtBearerSecurity(Configuration);   // Service Extensions

            #endregion

            #region "Add - JWT - (AddAuthorization) - Policies"

            //services.AddMvc(config =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //                         .RequireAuthenticatedUser()
            //                         .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});

            // TODO: GP SORT THIS CODE OUT!!!!
            // https://docs.microsoft.com/en-us/aspnet/core/security/authorization/claims?view=aspnetcore-2.1
            // https://stackoverflow.com/questions/47029512/net-core-2-0-jwt-bearer-not-protecting-routes
            // [Authorize(Policy = "EmployeeOnly")]
            // public IActionResult VacationBalance()
            services.AddAuthorization(options =>
            {
                options.AddPolicy("EmployeeOnly", policy => policy.RequireClaim("EmployeeNumber"));

            });
            #endregion

            services.AddMvc();
        }
        #endregion

        #region "2. USE - CONFIGURE HERE"

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            #region "Add/Use - Logging - works?"

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            #endregion

            #region "Use - Exceptions/Errors"

            // TODO: read and wire up.
            // http://www.talkingdotnet.com/aspnet-core-diagnostics-middleware-error-handling/
            //if (env.IsDevelopment()) {
            //    app.UseDeveloperExceptionPage();
            //}
            //else {
            //    app.UseExceptionHandler();
            //}
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();

            #endregion

            app.UseStaticFiles();

            #region "Use - Swagger Documentation - BEFORE --> JWT <--"

            // TODO: remove in production!!!
            // if (env.IsDevelopment())
                app.UseSwaggerDocumentation();

            #endregion

            #region "Use - Jwt - UseAuthentication"

            app.UseAuthentication();

            #endregion

            #region "Use - CORS - BEFORE --> UseMvc() <--"

            // https://stackoverflow.com/questions/48649878/cors-in-net-core-2-0-no-access-control-allow-origin-header-is-present-on-the
            // CORS middleware must precede any defined endpoints in your app that you want to support cross-origin requests(ex.before any call to UseMvc).
            app.UseCors("CorsPolicy");

            #endregion

            app.UseMvc(); 
            UAMClientLibrary.SetupClientLibrary("VisRes2", Configuration["Uam:Address"], Configuration["Uam:SAUserName"], Configuration["Uam:SAPassword"], "VisRes");
        }

        #endregion

    }

}
