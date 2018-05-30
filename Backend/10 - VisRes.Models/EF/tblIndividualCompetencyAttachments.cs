using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualCompetencyAttachments
    {
        [Key]
        public int IndividualCompetencyAttachmentID { get; set; }
        public int IndividualCompetencyID { get; set; }
        public int AttachmentID { get; set; }
        public int? AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentID")]
        [InverseProperty("tblIndividualCompetencyAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblIndividualCompetencyAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("IndividualCompetencyID")]
        [InverseProperty("tblIndividualCompetencyAttachments")]
        public tblIndividualCompetencies IndividualCompetency { get; set; }
    }
}
