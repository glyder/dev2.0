using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualIndividualRelations
    {
        public tblIndividualIndividualRelations()
        {
            tblIndividualIndividual = new HashSet<tblIndividualIndividual>();
        }

        [Key]
        public int IndividualIndividualRelationID { get; set; }
        [Required]
        [StringLength(50)]
        public string Relation { get; set; }

        [InverseProperty("Relationship")]
        public ICollection<tblIndividualIndividual> tblIndividualIndividual { get; set; }
    }
}
