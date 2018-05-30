using System.Collections.Generic;

namespace VisRes.Models.Model
{
    public class UserUpdateRequestModel
    {
        public int UserId { get; set; }
        public int IndividualId { get; set; }
        public List<string> Columns { get; set; }
        public List<string> Values { get; set; }
    }
}
