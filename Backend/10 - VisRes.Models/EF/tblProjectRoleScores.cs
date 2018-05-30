using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectRoleScores
    {
        [Key]
        public int ProjectRoleScoresID { get; set; }
        public int ProjectRoleID { get; set; }
        public int ScoreTypeID { get; set; }
        public int ScoresRequired { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("ProjectRoleID")]
        [InverseProperty("tblProjectRoleScores")]
        public tblProjectRoles ProjectRole { get; set; }
        [ForeignKey("ScoreTypeID")]
        [InverseProperty("tblProjectRoleScores")]
        public tblScoreTypes ScoreType { get; set; }
    }
}
