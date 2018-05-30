using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompetencyToJurisdiction
    {
        [Key]
        public int CompetencyToJurisdictionID { get; set; }
        public int CompetencyID { get; set; }
        public int JurisdictionID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblCompetencyToJurisdiction")]
        public tblCompetencies Competency { get; set; }
        [ForeignKey("JurisdictionID")]
        [InverseProperty("tblCompetencyToJurisdiction")]
        public tblJurisdictions Jurisdiction { get; set; }
    }
}
