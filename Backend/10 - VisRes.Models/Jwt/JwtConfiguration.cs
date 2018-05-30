using System;
using System.Collections.Generic;
using System.Text;

namespace VisRes.Models
{
    public class JwtConfiguration
    {
        public string Url { get; set; }
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}
