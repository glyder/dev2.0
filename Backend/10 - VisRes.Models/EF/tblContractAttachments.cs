using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblContractAttachments
    {
        [Key]
        public int ContractAttachmentID { get; set; }
        public int ContractID { get; set; }
        public int AttachmentID { get; set; }
        public int? AttachmentTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblContractAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("ContractID")]
        [InverseProperty("tblContractAttachments")]
        public tblContracts Contract { get; set; }
    }
}
