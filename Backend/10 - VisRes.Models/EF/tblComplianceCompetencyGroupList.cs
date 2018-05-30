using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblComplianceCompetencyGroupList
    {
        [Key]
        public int ComplianceCompetencyGroupListID { get; set; }
        public int ComplianceCompetencyGroupID { get; set; }
        public int CompetencyID { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
    }
}
