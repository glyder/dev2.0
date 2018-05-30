using System.Collections.Generic;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
//using NSwag.AspNetCore;
//using NSwag.SwaggerGeneration.Processors.Security;

namespace VisRes.Service.Api.Core
{
    /// <summary>
    /// Swagger / NSwag Config setting, extended out of startup.cs
    ///             
    /// DOCO: https://github.com/domaindrivendev/Swashbuckle.AspNetCore
    ///       https://docs.microsoft.com/de-de/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.1&tabs=visual-studio%2Cvisual-studio-xml
    /// </summary>
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            // Swagger / JWT - Integration required for the "Auhorization: Bearer xxxx" to work in Swagger UI
            // You have to enter this on EVERY OPERATION
            // So this worked just using this before I got the  AddSecurityDefinition / AddSecurityRequirement working
            // Here as a backup
            //      curl - X GET "http://localhost:65464/api/test/Books/GetAuthorized" - H "accept: text/plain" - H 
            //      "Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1MjM0NDIyNDgsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NDQ0NC8iLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQ0NDQvIn0.rLNsCFlDGVifADR-s8maJMF-UW0gfn8-jxDN1gLmEwY"
            //services.ConfigureSwaggerGen(options => { options.OperationFilter<AuthorizationHeaderParameterOperationFilter>(); });

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                //// Tweak for JWT support to get a LOGIN/LOGOUT button on Swagger UI!
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\", provide value: \"Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });

                // BACKUP 1 (solution) - use this over BACKUP 2
                // https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/603
                // https://stackoverflow.com/questions/43447688/setting-up-swagger-asp-net-core-using-the-authorization-headers-bearer
                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    { "Bearer", new string[] { } }
                });

                c.SwaggerDoc("v1", new Info { Title = "VisRes API V1", Version = "v1" });
            });

            //// BACKUP 2 - Use either above or this to get "bearer" working on broken swaggerUI
            //services.ConfigureSwaggerGen(options => {
            //    options.DocumentFilter<SecurityRequirementsDocumentFilter>();
            //});

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            //// Swagger
            //SwaggerUiSettings options = new SwaggerUiSettings< SwaggerUiSettings();
            //options.Description = "My API";
            //options.Version = "1.0.0";
            //options.Title = "My API";
            //options.ValidateSpecification = true;

            //// add Authorization header to Swagger UI
            //options.OperationProcessors.Add(new OperationSecurityScopeProcessor("apiKey"));
            //options.DocumentProcessors.Add(new SecurityDefinitionAppender("apiKey", new NSwag.SwaggerSecurityScheme()
            //{
            //    Type = NSwag.SwaggerSecuritySchemeType.ApiKey,
            //    Name = "Authorization",
            //    In = NSwag.SwaggerSecurityApiKeyLocation.Header,
            //    Description = "Bearer token"
            //}));
            //app.UseSwaggerUi(typeof(Startup).GetTypeInfo().Assembly, options);


            // Enable middleware to serve swagger - ui(HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "VisRes API V1");
                c.OAuthUseBasicAuthenticationWithAccessCodeGrant();
                c.DocExpansion(DocExpansion.None);                      // None, List, Full
            });

            //app.UseSwaggerUi(typeof(Startup).Assembly, settings =>
            //{
            //    // configure settings here
            //    settings.GeneratorSettings.DefaultPropertyNameHandling = PropertyNameHandling.CamelCase;
            //    // settings.OAuth2Client
            //});

            return app;
        }
    }
}