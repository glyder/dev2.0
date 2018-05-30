using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyAccreditationAttachments
    {
        [Key]
        public int CompanyAccreditationAttachmentID { get; set; }
        public int CompanyAccreditationID { get; set; }
        public int AttachmentID { get; set; }
        public int? AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentID")]
        [InverseProperty("tblCompanyAccreditationAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblCompanyAccreditationAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("CompanyAccreditationID")]
        [InverseProperty("tblCompanyAccreditationAttachments")]
        public tblCompanyAccreditations CompanyAccreditation { get; set; }
    }
}
