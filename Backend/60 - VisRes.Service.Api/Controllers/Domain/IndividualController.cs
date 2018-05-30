using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using VisRes.Models.EF;

namespace VisRes.Service.Api.Controllers.Domain
{
    [Produces("application/json")]
    [Route("api/Individual")]
    public class IndividualController : Controller
    {
        [Route("v1/{userId}/projects")]
        [HttpGet]
        ///api/v1/products
        ///api/v2/products
        public IEnumerable<tblProjects> GetProjectsByUserId(int userId) {
            return null;
        }

        [Route("v2/{userId}/projects")]
        [HttpGet]
        ///api/v1/products
        ///api/v2/products
        public IEnumerable<tblProjects> GetProjectsByUserIdFull(int userId)
        {
            return null;
        }

        //// GET: api/Individual
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Individual/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Individual
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Individual/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
