
using System.Collections.Generic;

namespace VisRes.Models.Test
{
    public class UserModel
    {
        public int UserId { get; set; }
        public int IndividualId { get; set; }
        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserLevel { get; set; }
        public int UserLevelId { get; set; }
        public string ProjectName { get; set; }

        public string PersonalPhoto { get; set; }
        public List<string> Projects { get; set; }

        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }

        public bool IsActive { get; set; }
    }

    public class UserUpdateRequestModel
    {
        public int UserId { get; set; }
        public int IndividualId { get; set; }
        public List<string> Columns { get; set; }
        public List<string> Values { get; set; }
    }
}
