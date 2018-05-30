using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblPlantComments
    {
        [Key]
        public int PlantCommentID { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        public int PlantID { get; set; }

        [ForeignKey("PlantID")]
        [InverseProperty("tblPlantComments")]
        public tblPlants Plant { get; set; }
    }
}
