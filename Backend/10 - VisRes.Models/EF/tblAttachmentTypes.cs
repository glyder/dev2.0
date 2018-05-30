using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAttachmentTypes
    {
        public tblAttachmentTypes()
        {
            tblCompanyAccreditationAttachments = new HashSet<tblCompanyAccreditationAttachments>();
            tblCompanyAttachments = new HashSet<tblCompanyAttachments>();
            tblCompanyOnboardingAttachments = new HashSet<tblCompanyOnboardingAttachments>();
            tblContractAttachments = new HashSet<tblContractAttachments>();
            tblIndividualAttachments = new HashSet<tblIndividualAttachments>();
            tblIndividualCompetencyAttachments = new HashSet<tblIndividualCompetencyAttachments>();
            tblInsuranceAttachments = new HashSet<tblInsuranceAttachments>();
            tblPlantAttachments = new HashSet<tblPlantAttachments>();
            tblProjectAttachments = new HashSet<tblProjectAttachments>();
            tblSuspensionNotes = new HashSet<tblSuspensionNotes>();
        }

        [Key]
        public int AttachmentTypeID { get; set; }
        [Required]
        [StringLength(100)]
        public string Type { get; set; }
        public int AttachmentTypeCategoryID { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public bool DownloadRestricted { get; set; }
        public bool IsMandatory { get; set; }

        [InverseProperty("AttachmentType")]
        public ICollection<tblCompanyAccreditationAttachments> tblCompanyAccreditationAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblCompanyAttachments> tblCompanyAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblCompanyOnboardingAttachments> tblCompanyOnboardingAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblContractAttachments> tblContractAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblIndividualAttachments> tblIndividualAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblIndividualCompetencyAttachments> tblIndividualCompetencyAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblInsuranceAttachments> tblInsuranceAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblPlantAttachments> tblPlantAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblProjectAttachments> tblProjectAttachments { get; set; }
        [InverseProperty("AttachmentType")]
        public ICollection<tblSuspensionNotes> tblSuspensionNotes { get; set; }
    }
}
