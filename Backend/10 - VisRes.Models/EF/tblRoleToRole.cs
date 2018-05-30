using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblRoleToRole
    {
        [Key]
        public int RoleToRoleID { get; set; }
        public int ParentRoleID { get; set; }
        public int ContainedRoleID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("ContainedRoleID")]
        [InverseProperty("tblRoleToRoleContainedRole")]
        public tblRoleLibrary ContainedRole { get; set; }
        [ForeignKey("ParentRoleID")]
        [InverseProperty("tblRoleToRoleParentRole")]
        public tblRoleLibrary ParentRole { get; set; }
    }
}
