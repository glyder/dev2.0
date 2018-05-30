using System;
using System.Security.Claims;

namespace VisRes.Models.Model
{
    public class JwtModel
    {
        public bool Valid { get; set; } = false;            // NOT VALID by default
        public string Username{ get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }


        public string Token { get; set; }

        public string Roles { get; set; }
    }

 }
