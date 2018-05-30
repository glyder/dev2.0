using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompetencyTypes
    {
        public tblCompetencyTypes()
        {
            tblCompetencies = new HashSet<tblCompetencies>();
        }

        [Key]
        public int CompetencyTypeID { get; set; }
        [Required]
        [StringLength(120)]
        public string Type { get; set; }
        public bool ComplianceContributed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [InverseProperty("CompetencyType")]
        public ICollection<tblCompetencies> tblCompetencies { get; set; }
    }
}
