namespace VisRes.Models.Model
{
    public partial class UserUamModel
    {
        public object Access { get; set; }                  // "Accesses": [],
        public bool Active { get; set; }                    // true
        public string Address { get; set; }                 // "25 - 37 Huntingdale Rd, Burwood VIC 3125",
        public string Company { get; set; }                 // null
        public string Email { get; set; }                   // "George.Pagotelis@xxxx",
        public string Error { get; set; }                   // "Error": null,
        public bool ExternalUser { get; set; }              // false
        public object FailedCountExternal { get; set; }     // null
        public string Fax { get; set; }                     // ""
        public string FullName { get; set; }                // "George Pagotelis"
        public string LoginId { get; set; }                 // "GPagotelis"
        public string Manager { get; set; }                 // null
        public string Mobile { get; set; }                  // ""
        public object Modules { get; set; }                 // []
        public string Password { get; set; }                // ""
        public string Phone { get; set; }                   // "TBA"
        public object Projects { get; set; }                // []
        public string State { get; set; }                   // ""
        public string Title { get; set; }                   // "Systems Developer"
        public int UserId { get; set; }                     // 0
        public string UserImage { get; set; }               // ""
        public object VisresIndividualId { get; set; }      // null
    }

    // Extend with extra members 
    public partial class UserUamModel
    {
        public string Milliseconds { get; set; }
        public string ErrorException { get; set; }
    }
}
