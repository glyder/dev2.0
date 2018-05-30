using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualSubStatuses
    {
        public tblIndividualSubStatuses()
        {
            tblIndividuals = new HashSet<tblIndividuals>();
        }

        [Key]
        public int IndividualSubStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubStatus { get; set; }

        [InverseProperty("IndividualSubStatus")]
        public ICollection<tblIndividuals> tblIndividuals { get; set; }
    }
}
