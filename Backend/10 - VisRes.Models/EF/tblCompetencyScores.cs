using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompetencyScores
    {
        [Key]
        public int CompetencyScoreID { get; set; }
        public int CompetencyID { get; set; }
        public int Score { get; set; }
        public int ScoreTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblCompetencyScores")]
        public tblCompetencies Competency { get; set; }
        [ForeignKey("ScoreTypeID")]
        [InverseProperty("tblCompetencyScores")]
        public tblScoreTypes ScoreType { get; set; }
    }
}
