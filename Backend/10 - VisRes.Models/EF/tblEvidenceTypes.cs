using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblEvidenceTypes
    {
        public tblEvidenceTypes()
        {
            tblIndividualCompetencies = new HashSet<tblIndividualCompetencies>();
        }

        [Key]
        [Column("EvidenceTypeID")]
        public int EvidenceTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [InverseProperty("EvidenceType")]
        public ICollection<tblIndividualCompetencies> tblIndividualCompetencies { get; set; }
    }
}
