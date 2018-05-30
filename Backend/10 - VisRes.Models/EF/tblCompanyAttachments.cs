using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyAttachments
    {
        [Key]
        public int CompanyAttachmentID { get; set; }
        public int CompanyID { get; set; }
        public int AttachmentID { get; set; }
        public int AttachmentTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        public int? ProjectID { get; set; }

        [ForeignKey("AttachmentID")]
        [InverseProperty("tblCompanyAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblCompanyAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyAttachments")]
        public tblCompanies Company { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblCompanyAttachments")]
        public tblProjects Project { get; set; }
    }
}
