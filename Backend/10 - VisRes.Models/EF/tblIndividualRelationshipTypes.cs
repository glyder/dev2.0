using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualRelationshipTypes
    {
        public tblIndividualRelationshipTypes()
        {
            tblIndividualIndividual = new HashSet<tblIndividualIndividual>();
        }

        [Key]
        public int IndividualRelationshipTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [InverseProperty("RelationshipType")]
        public ICollection<tblIndividualIndividual> tblIndividualIndividual { get; set; }
    }
}
