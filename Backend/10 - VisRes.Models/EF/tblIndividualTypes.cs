using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualTypes
    {
        public tblIndividualTypes()
        {
            tblIndividuals = new HashSet<tblIndividuals>();
        }

        [Key]
        public int IndividualTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [InverseProperty("IndividualType")]
        public ICollection<tblIndividuals> tblIndividuals { get; set; }
    }
}
