using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblDefaultProjectRoles
    {
        [Key]
        public int DefaultProjectRoleID { get; set; }
        public int ProjectRoleID { get; set; }
        public int CompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblDefaultProjectRoles")]
        public tblCompanies Company { get; set; }
        [ForeignKey("ProjectRoleID")]
        [InverseProperty("tblDefaultProjectRoles")]
        public tblProjectRoles ProjectRole { get; set; }
    }
}
