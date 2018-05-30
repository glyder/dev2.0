using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblUsers
    {
        public tblUsers()
        {
            tblUserProjects = new HashSet<tblUserProjects>();
            tblUserSessions = new HashSet<tblUserSessions>();
        }

        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(120)]
        public string UserName { get; set; }
        public int? IndividualID { get; set; }
        public int UserLevelID { get; set; }
        [StringLength(100)]
        public string FullName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(120)]
        public string Email { get; set; }
        [StringLength(120)]
        public string Location { get; set; }
        [Required]
        [StringLength(120)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        public int? PasswordExpiryDaysID { get; set; }
        public bool? ForcePasswordChange { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PasswordChangedOn { get; set; }
        public bool? IsMultiCompanyUser { get; set; }

        [ForeignKey("UserLevelID")]
        [InverseProperty("tblUsers")]
        public tblUserLevels UserLevel { get; set; }
        [InverseProperty("User")]
        public ICollection<tblUserProjects> tblUserProjects { get; set; }
        [InverseProperty("User")]
        public ICollection<tblUserSessions> tblUserSessions { get; set; }
    }
}
