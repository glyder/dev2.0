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


// TODO: Roles/Policy/....
// https://kimsereyblog.blogspot.com.au/2017/04/different-types-of-authorization-in.html

namespace VisRes.Service.Api.Controllers
{
    // [Produces("application/json")]
    [Route("api/test/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var currentUser = HttpContext.User;
            var resultBookList = new Book[] {
                new Book { Id=1, Author = "Ray Bradbury",Title = "Fahrenheit 451" },
                new Book { Id=2, Author = "Gabriel García Márquez", Title = "One Hundred years of Solitude" },
                new Book { Id=3, Author = "George Orwell", Title = "1984" },
                new Book { Id=4, Author = "Anais Nin", Title = "Delta of Venus" }
            };

            return resultBookList;
        }

        [HttpGet, Authorize(Roles="user")]
        [Route("GetAuthorized")]
        public IEnumerable<Book> GetAuthorized()
        {
            // Get current User
            var currentUser = HttpContext.User;

            int userAge = 0;

            var resultBookList = new Book[] {
                new Book { Id=1, Author = "Mr Authorized",Title = "You are Authorized!!!" },
                new Book { Id=2, Author = "Gabriel García Márquez", Title = "One Hundred years of Solitude" },
                new Book { Id=3, Author = "George Orwell", Title = "1984" },
                new Book { Id=4, Author = "Anais Nin", Title = "Delta of Venus" },
                new Book { Id=5, Author = "Brain Taylor", Title = "Tunnel nightclub", AgeRestriction=true}
            };

            // Get Claims
            if (currentUser.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
            {
                DateTime birthDate = DateTime.Parse(currentUser.Claims
                                                               .FirstOrDefault(c => c.Type == ClaimTypes.DateOfBirth).Value);
                userAge = DateTime.Today.Year - birthDate.Year;
            }

            if (userAge < 18)
            {
                resultBookList = resultBookList.Where(b => !b.AgeRestriction).ToArray();
            }

            return resultBookList;
        }

        [HttpGet, Authorize(Roles ="admin")]
        [Route("GetAdmin")]
        public IEnumerable<Book> GetAdmin()
        {

            var currentUser = HttpContext.User;
            // currentUser.HasClaim(c => c.Type == ClaimTypes.
            
            // Split(',').Contains("apple")



            var resultBookList = new Book[] {
                new Book { Id=1, Author = "Mr Admin",Title = "You are Mr Admin!!!!" },
                new Book { Id=2, Author = "Gabriel García Márquez", Title = "One Hundred years of Solitude" },
                new Book { Id=3, Author = "George Orwell", Title = "1984" },
                new Book { Id=4, Author = "Anais Nin", Title = "Delta of Venus" }
            };

            return resultBookList;
        }

        public class Book
        {
            public int Id { get; set; }
            public string Author { get; set; }
            public string Title { get; set; }
            public bool AgeRestriction { get; set; }
        }
    }
}
