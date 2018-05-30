using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblComplianceCompetencyGroups
    {
        public tblComplianceCompetencyGroups()
        {
            tblAlternativeCompetencies = new HashSet<tblAlternativeCompetencies>();
        }

        [Key]
        public int ComplianceCompetencyGroupID { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }

        [InverseProperty("CanBeReplacedByGroupNavigation")]
        public ICollection<tblAlternativeCompetencies> tblAlternativeCompetencies { get; set; }
    }
}
