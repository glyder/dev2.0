using System;
using System.Security.Claims;


namespace VisRes.Models.Model
{
    public class ClaimModel
    {
        JwtModel User { get; set; }

        Claim[] claims { get; set; }
    }
}
