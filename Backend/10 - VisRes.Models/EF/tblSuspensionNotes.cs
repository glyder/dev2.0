using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblSuspensionNotes
    {
        [Key]
        public int SuspensionNoteID { get; set; }
        public int SuspensionID { get; set; }
        public int? NoteNo { get; set; }
        public string Note { get; set; }
        public int? AttachmentID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        public int? AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblSuspensionNotes")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("SuspensionID")]
        [InverseProperty("tblSuspensionNotes")]
        public tblSuspensions Suspension { get; set; }
    }
}
