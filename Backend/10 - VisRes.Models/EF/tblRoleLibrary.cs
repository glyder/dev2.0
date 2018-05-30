using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblRoleLibrary
    {
        public tblRoleLibrary()
        {
            tblProjectRoleToRoleLibrary = new HashSet<tblProjectRoleToRoleLibrary>();
            tblRoleToCompetency = new HashSet<tblRoleToCompetency>();
            tblRoleToGroup = new HashSet<tblRoleToGroup>();
            tblRoleToRoleContainedRole = new HashSet<tblRoleToRole>();
            tblRoleToRoleParentRole = new HashSet<tblRoleToRole>();
        }

        [Key]
        public int RoleID { get; set; }
        [Required]
        [StringLength(127)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [InverseProperty("RoleLibrary")]
        public ICollection<tblProjectRoleToRoleLibrary> tblProjectRoleToRoleLibrary { get; set; }
        [InverseProperty("Role")]
        public ICollection<tblRoleToCompetency> tblRoleToCompetency { get; set; }
        [InverseProperty("Role")]
        public ICollection<tblRoleToGroup> tblRoleToGroup { get; set; }
        [InverseProperty("ContainedRole")]
        public ICollection<tblRoleToRole> tblRoleToRoleContainedRole { get; set; }
        [InverseProperty("ParentRole")]
        public ICollection<tblRoleToRole> tblRoleToRoleParentRole { get; set; }
    }
}
