using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblRCGroups
    {
        public tblRCGroups()
        {
            tblCompetencyToRCGroup = new HashSet<tblCompetencyToRCGroup>();
            tblRCGHierarchiesChildRCGNavigation = new HashSet<tblRCGHierarchies>();
            tblRCGHierarchiesParentRCGNavigation = new HashSet<tblRCGHierarchies>();
            tblRoleToGroup = new HashSet<tblRoleToGroup>();
        }

        [Key]
        public int RCGroupID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [InverseProperty("RCGroup")]
        public ICollection<tblCompetencyToRCGroup> tblCompetencyToRCGroup { get; set; }
        [InverseProperty("ChildRCGNavigation")]
        public ICollection<tblRCGHierarchies> tblRCGHierarchiesChildRCGNavigation { get; set; }
        [InverseProperty("ParentRCGNavigation")]
        public ICollection<tblRCGHierarchies> tblRCGHierarchiesParentRCGNavigation { get; set; }
        [InverseProperty("RCGroup")]
        public ICollection<tblRoleToGroup> tblRoleToGroup { get; set; }
    }
}
