using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblRoleToGroup
    {
        [Key]
        public int RoleToRCGroupID { get; set; }
        public int RoleID { get; set; }
        public int RCGroupID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("RCGroupID")]
        [InverseProperty("tblRoleToGroup")]
        public tblRCGroups RCGroup { get; set; }
        [ForeignKey("RoleID")]
        [InverseProperty("tblRoleToGroup")]
        public tblRoleLibrary Role { get; set; }
    }
}
