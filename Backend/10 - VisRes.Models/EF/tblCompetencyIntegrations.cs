using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompetencyIntegrations
    {
        [Key]
        public int CompetencyIntegrationID { get; set; }
        public int CompetencyID { get; set; }
        [Required]
        [StringLength(255)]
        public string IntegratedSystem { get; set; }
        [Required]
        [StringLength(255)]
        public string Key { get; set; }
        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblCompetencyIntegrations")]
        public tblCompetencies Competency { get; set; }
    }
}
