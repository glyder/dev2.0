using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualIndividual
    {
        [Key]
        public int IndividualIndividualID { get; set; }
        public int MainIndividualID { get; set; }
        public int RelatedIndividualID { get; set; }
        public int RelationshipID { get; set; }
        public int RelationshipTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("MainIndividualID")]
        [InverseProperty("tblIndividualIndividualMainIndividual")]
        public tblIndividuals MainIndividual { get; set; }
        [ForeignKey("RelatedIndividualID")]
        [InverseProperty("tblIndividualIndividualRelatedIndividual")]
        public tblIndividuals RelatedIndividual { get; set; }
        [ForeignKey("RelationshipID")]
        [InverseProperty("tblIndividualIndividual")]
        public tblIndividualIndividualRelations Relationship { get; set; }
        [ForeignKey("RelationshipTypeID")]
        [InverseProperty("tblIndividualIndividual")]
        public tblIndividualRelationshipTypes RelationshipType { get; set; }
    }
}
