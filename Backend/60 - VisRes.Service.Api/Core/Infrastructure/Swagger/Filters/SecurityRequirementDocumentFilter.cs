using System.Collections.Generic;
using System.Linq;

// Added
using Microsoft.AspNetCore.Mvc.Authorization;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Swagger;


namespace VisRes.Service.Api.Core.Swagger
{
    public class SecurityRequirementsDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument document, DocumentFilterContext context)
        {
            document.Security = new List<IDictionary<string, IEnumerable<string>>>()
        {
            new Dictionary<string, IEnumerable<string>>()
            {
                { "Bearer", new string[]{ } },
                { "Basic", new string[]{ } },
            }
        };
        }
    }
}
