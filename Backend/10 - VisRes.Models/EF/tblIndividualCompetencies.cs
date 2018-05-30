using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualCompetencies
    {
        public tblIndividualCompetencies()
        {
            tblIndividualCompetencyAttachments = new HashSet<tblIndividualCompetencyAttachments>();
        }

        [Key]
        public int IndividualCompetencyID { get; set; }
        public int IndividualID { get; set; }
        public int CompetencyID { get; set; }
        public int? AssessedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AssessmentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        public int? ProviderID { get; set; }
        [StringLength(50)]
        public string EvidenceNumber { get; set; }
        public int? EvidenceLevelID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        public int IndividualCompetencySubStatusID { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblIndividualCompetencies")]
        public tblCompetencies Competency { get; set; }
        [ForeignKey("EvidenceLevelID")]
        [InverseProperty("tblIndividualCompetencies")]
        public tblEvidenceLevel EvidenceLevel { get; set; }
        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualCompetencies")]
        public tblIndividuals Individual { get; set; }
        [ForeignKey("IndividualCompetencyID")]
        [InverseProperty("InverseIndividualCompetency")]
        public tblIndividualCompetencies IndividualCompetency { get; set; }
        [ForeignKey("IndividualCompetencySubStatusID")]
        [InverseProperty("tblIndividualCompetencies")]
        public tblIndividualCompetencySubStatuses IndividualCompetencySubStatus { get; set; }
        [ForeignKey("ProviderID")]
        [InverseProperty("tblIndividualCompetencies")]
        public tblCompanies Provider { get; set; }
        [InverseProperty("IndividualCompetency")]
        public tblIndividualCompetencies InverseIndividualCompetency { get; set; }
        [InverseProperty("IndividualCompetency")]
        public ICollection<tblIndividualCompetencyAttachments> tblIndividualCompetencyAttachments { get; set; }
    }
}
