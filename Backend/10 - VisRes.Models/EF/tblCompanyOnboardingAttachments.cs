using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyOnboardingAttachments
    {
        [Key]
        public int CompanyOnboardingAttachmentID { get; set; }
        public int CompanyOnboardingID { get; set; }
        public int AttachmentID { get; set; }
        public int? AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblCompanyOnboardingAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("CompanyOnboardingID")]
        [InverseProperty("tblCompanyOnboardingAttachments")]
        public tblCompanyOnboarding CompanyOnboarding { get; set; }
    }
}
