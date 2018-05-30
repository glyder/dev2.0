using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisRes.Data.EFCore;
using VisRes.Models.EF;
using System.Security.Claims;


namespace VisRes.Service.Api.Controllers
{
    // [Produces("application/json")]
    [Route("api/users/[controller]")]
    public class UsersController : Controller
    {
        // GET api/users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var currentUser = HttpContext.User;

            var resultBookList = new User[] {
                new User {
                    Id =1,
                    Firstname ="test",
                    Lastname ="test",
                    Username ="test",
                    Password ="test"
                },
            };

            return resultBookList;
        }

        //// Change to Async
        //// GET api/values
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    // imagine some db logic
        //    List<string> values = new List<string>() { "value1", "value2", "gp" };
        //    return Ok(values);
        //}

                             
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = new User { Id = 1, Firstname = "test", Lastname = "test", Username = "test", Password = "test" };
            return user;
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // Change to Async
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]User value)
        {
            // imagine some db logic
            return Created("", value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Password { get; set; }
        }
    }
}
