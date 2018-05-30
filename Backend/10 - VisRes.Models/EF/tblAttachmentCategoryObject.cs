using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAttachmentCategoryObject
    {
        [Key]
        public int AttachmentCategoryObjectID { get; set; }
        public int AttachmentTypeCategoryID { get; set; }
        [Required]
        [StringLength(120)]
        public string ObjectName { get; set; }

        [ForeignKey("AttachmentTypeCategoryID")]
        [InverseProperty("tblAttachmentCategoryObject")]
        public tblAttachmentTypeCategory AttachmentTypeCategory { get; set; }
    }
}
