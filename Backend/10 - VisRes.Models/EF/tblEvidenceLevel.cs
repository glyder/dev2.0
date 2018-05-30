using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblEvidenceLevel
    {
        public tblEvidenceLevel()
        {
            tblIndividualCompetencies = new HashSet<tblIndividualCompetencies>();
            tblProjectRoleToCompetency = new HashSet<tblProjectRoleToCompetency>();
        }

        [Key]
        public int EvidenceLevelID { get; set; }
        [Required]
        [StringLength(50)]
        public string LevelName { get; set; }
        public int? LevelScore { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [InverseProperty("EvidenceLevel")]
        public ICollection<tblIndividualCompetencies> tblIndividualCompetencies { get; set; }
        [InverseProperty("MinimalEvidenceLevel")]
        public ICollection<tblProjectRoleToCompetency> tblProjectRoleToCompetency { get; set; }
    }
}
