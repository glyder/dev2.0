using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualIDCardAttachments
    {
        [Key]
        [Column("IndividualIDCardAttachmentID")]
        public int IndividualIdcardAttachmentID { get; set; }
        [Column("IndividualIDCardID")]
        public int IndividualIdcardID { get; set; }
        [Column("AttachmentID")]
        public int AttachmentID { get; set; }
        [Column("AttachmentTypeID")]
        public int? AttachmentTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("AttachmentId")]
        [InverseProperty("tblIndividualIDCardAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeId")]
        [InverseProperty("tblIndividualIDCardAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("IndividualIdcardId")]
        [InverseProperty("tblIndividualIDCardAttachments")]
        public tblIndividualIDCards IndividualIdcard { get; set; }
    }
}
