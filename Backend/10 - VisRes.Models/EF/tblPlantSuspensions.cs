using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblPlantSuspensions
    {
        [Key]
        public int PlantSuspensionID { get; set; }
        public int SuspensionID { get; set; }
        public int PlantID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("PlantID")]
        [InverseProperty("tblPlantSuspensions")]
        public tblPlants Plant { get; set; }
        [ForeignKey("SuspensionID")]
        [InverseProperty("tblPlantSuspensions")]
        public tblSuspensions Suspension { get; set; }
    }
}
