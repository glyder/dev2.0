using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblPlantAttachments
    {
        [Key]
        public int PlantAttachmentID { get; set; }
        public int PlantID { get; set; }
        public int AttachmentID { get; set; }
        public int? AttachmentTypeID { get; set; }

        [ForeignKey("AttachmentID")]
        [InverseProperty("tblPlantAttachments")]
        public tblAttachments Attachment { get; set; }
        [ForeignKey("AttachmentTypeID")]
        [InverseProperty("tblPlantAttachments")]
        public tblAttachmentTypes AttachmentType { get; set; }
        [ForeignKey("PlantID")]
        [InverseProperty("tblPlantAttachments")]
        public tblPlants Plant { get; set; }
    }
}
