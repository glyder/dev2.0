using System;
using System.Security.Claims;

namespace VisRes.Models.Model
{
    public class UserJwtModel
    {
        public bool Valid { get; set; } = false;            // NOT VALID by default

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }


        public string Token { get; set; }

        public string Roles { get; set; }
    }


    public class UserClaimModel
    {
        UserJwtModel User { get; set; }

        Claim[] claims { get; set; }
    }
}
