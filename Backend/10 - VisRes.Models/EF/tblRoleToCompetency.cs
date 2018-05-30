using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblRoleToCompetency
    {
        [Key]
        public int RoleToCompetencyID { get; set; }
        public int RoleID { get; set; }
        public int CompetencyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblRoleToCompetency")]
        public tblCompetencies Competency { get; set; }
        [ForeignKey("RoleID")]
        [InverseProperty("tblRoleToCompetency")]
        public tblRoleLibrary Role { get; set; }
    }
}
