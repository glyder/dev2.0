using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualStatuses
    {
        public tblIndividualStatuses()
        {
            tblIndividuals = new HashSet<tblIndividuals>();
        }

        [Key]
        public int IndividualStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IndividualStatus")]
        public ICollection<tblIndividuals> tblIndividuals { get; set; }
    }
}
