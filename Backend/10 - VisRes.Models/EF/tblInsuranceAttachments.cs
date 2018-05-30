using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblInsuranceAttachments
    {
        [Key]
        public int InsuranceAttachmentID { get; set; }
        public int InsuranceID { get; set; }
        public int AttachmentID { get; set; }
        public int? AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentID")]
        [InverseProperty("tblInsuranceAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblInsuranceAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("InsuranceID")]
        [InverseProperty("tblInsuranceAttachments")]
        public tblInsurances Insurance { get; set; }
    }
}
