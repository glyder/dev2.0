using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualComments
    {
        [Key]
        public int IndividualCommentID { get; set; }
        public int IndividualID { get; set; }
        public int? CommentNo { get; set; }
        public string Comment { get; set; }
        public int? AttachmentID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualComments")]
        public tblIndividuals Individual { get; set; }
    }
}
