using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectRoleToCompetency
    {
        [Key]
        public int ProjectRoleToCompetencyID { get; set; }
        public int ProjectRoleID { get; set; }
        public int CompetencyID { get; set; }
        public int? MinimalEvidenceLevelID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblProjectRoleToCompetency")]
        public tblCompetencies Competency { get; set; }
        [ForeignKey("MinimalEvidenceLevelID")]
        [InverseProperty("tblProjectRoleToCompetency")]
        public tblEvidenceLevel MinimalEvidenceLevel { get; set; }
        [ForeignKey("ProjectRoleID")]
        [InverseProperty("tblProjectRoleToCompetency")]
        public tblProjectRoles ProjectRole { get; set; }
    }
}
