using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAttachmentTypeCategory
    {
        public tblAttachmentTypeCategory()
        {
            tblAttachmentCategoryObject = new HashSet<tblAttachmentCategoryObject>();
        }

        [Key]
        public int AttachmentTypeCategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string Category { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [InverseProperty("AttachmentTypeCategory")]
        public ICollection<tblAttachmentCategoryObject> tblAttachmentCategoryObject { get; set; }
    }
}
