using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualAttachments
    {
        [Key]
        public int IndividualAttachmentID { get; set; }
        public int IndividualID { get; set; }
        public int AttachmentID { get; set; }
        public int AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentID")]
        [InverseProperty("tblIndividualAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblIndividualAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualAttachments")]
        public tblIndividuals Individual { get; set; }
    }
}
