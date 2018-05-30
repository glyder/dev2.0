using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblScoreTypes
    {
        public tblScoreTypes()
        {
            tblCompetencyScores = new HashSet<tblCompetencyScores>();
            tblProjectRoleScores = new HashSet<tblProjectRoleScores>();
        }

        [Key]
        public int ScoreTypeID { get; set; }
        [Required]
        [StringLength(127)]
        public string Type { get; set; }

        [InverseProperty("ScoreType")]
        public ICollection<tblCompetencyScores> tblCompetencyScores { get; set; }
        [InverseProperty("ScoreType")]
        public ICollection<tblProjectRoleScores> tblProjectRoleScores { get; set; }
    }
}
