using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblRCGHierarchies
    {
        [Key]
        public int RCGHierarchyID { get; set; }
        public int ParentRCG { get; set; }
        public int ChildRCG { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("ChildRCG")]
        [InverseProperty("tblRCGHierarchiesChildRCGNavigation")]
        public tblRCGroups ChildRCGNavigation { get; set; }
        [ForeignKey("ParentRCG")]
        [InverseProperty("tblRCGHierarchiesParentRCGNavigation")]
        public tblRCGroups ParentRCGNavigation { get; set; }
    }
}
