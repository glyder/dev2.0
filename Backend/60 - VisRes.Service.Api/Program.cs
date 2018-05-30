using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using VisRes.Data.EFCore;

namespace VisRes.Service.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();

            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var contextVrs = services.GetRequiredService<VrsContext>();

                var logger = services.GetRequiredService<ILogger<Program>>();

                try
                {
                    //VrsDbInitializer.Initialize(contextVrs, logger);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) => 
            WebHost.CreateDefaultBuilder(args)
                    .UseKestrel()                                           // check IIS doesn't break with this!!!
                    .UseContentRoot(Directory.GetCurrentDirectory())        //(@"C:\inetpub\wwwroot\VisRes2.0")
                    .UseIISIntegration()
                    .UseStartup<Startup>()
                    //.CaptureStartupErrors(true)
                    //.UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
                    //.UseEnvironment("Development")
                    //.PreferHostingUrls(false)
                    //.UseUrls("http://*:8080;http://localhost:8080/api;")
                    //.UseDeveloperExceptionPage()
                    .Build();
    }
}
