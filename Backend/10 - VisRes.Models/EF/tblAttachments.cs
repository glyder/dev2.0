using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAttachments
    {
        public tblAttachments()
        {
            tblCompanyAccreditationAttachments = new HashSet<tblCompanyAccreditationAttachments>();
            tblCompanyAttachments = new HashSet<tblCompanyAttachments>();
            tblIndividualAttachments = new HashSet<tblIndividualAttachments>();
            tblIndividualCompetencyAttachments = new HashSet<tblIndividualCompetencyAttachments>();
            tblInsuranceAttachments = new HashSet<tblInsuranceAttachments>();
            tblPlantAttachments = new HashSet<tblPlantAttachments>();
            tblProjectAttachments = new HashSet<tblProjectAttachments>();
        }

        [Key]
        public int AttachmentID { get; set; }
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [StringLength(255)]
        public string ContentType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string OriginalFileName { get; set; }
        public bool IsDeleted { get; set; }

        [InverseProperty("Attachment")]
        public ICollection<tblCompanyAccreditationAttachments> tblCompanyAccreditationAttachments { get; set; }
        [InverseProperty("Attachment")]
        public ICollection<tblCompanyAttachments> tblCompanyAttachments { get; set; }
        [InverseProperty("Attachment")]
        public ICollection<tblIndividualAttachments> tblIndividualAttachments { get; set; }
        [InverseProperty("Attachment")]
        public ICollection<tblIndividualCompetencyAttachments> tblIndividualCompetencyAttachments { get; set; }
        [InverseProperty("Attachment")]
        public ICollection<tblInsuranceAttachments> tblInsuranceAttachments { get; set; }
        [InverseProperty("Attachment")]
        public ICollection<tblPlantAttachments> tblPlantAttachments { get; set; }
        [InverseProperty("Attachment")]
        public ICollection<tblProjectAttachments> tblProjectAttachments { get; set; }
    }
}
