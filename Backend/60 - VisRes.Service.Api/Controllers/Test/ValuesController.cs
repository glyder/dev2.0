using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisRes.Data.EFCore;
using VisRes.Models.EF;

namespace VisRes.Service.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/test/[controller]")]
    public class ValuesController : Controller
    {
        private readonly VrsContext _context;

        public ValuesController(VrsContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        [HttpGet]
        [Route("GP")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public IEnumerable<tblLOBs> GetGP()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            // imagine some db logic
            List<string> values = new List<string>() { "bruce", "is", "special" };
            //return Ok(values);

            var lobs = _context.tblLOBs.AsNoTracking();

            return lobs.ToList();
        }


        //// GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get() {
        //    return new string[] { "value1", "value2" };
        //}

        // Change to Async
        // GET api/values
        [HttpGet]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> Get()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            // imagine some db logic
            List<string> values = new List<string>() { "value1", "value2", "gp" };
            return Ok(values);
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // Change to Async
        // POST api/values
        [HttpPost]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> Post([FromBody]string value)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            // imagine some db logic
            return Created("", value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
