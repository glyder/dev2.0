using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectAttachments
    {
        [Key]
        public int ProjectAttachmentID { get; set; }
        public int ProjectID { get; set; }
        public int AttachmentID { get; set; }
        public int? AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentID")]
        [InverseProperty("tblProjectAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblProjectAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblProjectAttachments")]
        public tblProjects Project { get; set; }
    }
}
