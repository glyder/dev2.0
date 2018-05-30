using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompetencyToRCGroup
    {
        [Key]
        public int CompetencyToRCGroupID { get; set; }
        public int CompetencyID { get; set; }
        public int RCGroupID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblCompetencyToRCGroup")]
        public tblCompetencies Competency { get; set; }
        [ForeignKey("RCGroupID")]
        [InverseProperty("tblCompetencyToRCGroup")]
        public tblRCGroups RCGroup { get; set; }
    }
}
