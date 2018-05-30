using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAlternativeCompetencies
    {
        [Key]
        public int AlternativeCompetencyID { get; set; }
        public int CompetencyID { get; set; }
        public int? CanBeReplacedByCompetency { get; set; }
        public int? CanBeReplacedByGroup { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CanBeReplacedByCompetency")]
        [InverseProperty("tblAlternativeCompetenciesCanBeReplacedByCompetencyNavigation")]
        public tblCompetencies CanBeReplacedByCompetencyNavigation { get; set; }
        [ForeignKey("CanBeReplacedByGroup")]
        [InverseProperty("tblAlternativeCompetencies")]
        public tblComplianceCompetencyGroups CanBeReplacedByGroupNavigation { get; set; }
        [ForeignKey("CompetencyID")]
        [InverseProperty("tblAlternativeCompetenciesCompetency")]
        public tblCompetencies Competency { get; set; }
    }
}
