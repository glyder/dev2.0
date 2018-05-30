using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectRoleToRoleLibrary
    {
        [Key]
        public int ProjectRoleToRoleID { get; set; }
        public int ProjectRoleID { get; set; }
        public int RoleLibraryID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("ProjectRoleID")]
        [InverseProperty("tblProjectRoleToRoleLibrary")]
        public tblProjectRoles ProjectRole { get; set; }
        [ForeignKey("RoleLibraryID")]
        [InverseProperty("tblProjectRoleToRoleLibrary")]
        public tblRoleLibrary RoleLibrary { get; set; }
    }
}
