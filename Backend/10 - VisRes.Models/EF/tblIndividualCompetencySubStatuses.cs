using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualCompetencySubStatuses
    {
        public tblIndividualCompetencySubStatuses()
        {
            tblIndividualCompetencies = new HashSet<tblIndividualCompetencies>();
        }

        [Key]
        public int IndividualCompetencySubStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubStatus { get; set; }

        [InverseProperty("IndividualCompetencySubStatus")]
        public ICollection<tblIndividualCompetencies> tblIndividualCompetencies { get; set; }
    }
}
