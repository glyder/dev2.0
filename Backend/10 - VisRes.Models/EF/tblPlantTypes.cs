using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblPlantTypes
    {
        public tblPlantTypes()
        {
            tblPlants = new HashSet<tblPlants>();
        }

        [Key]
        public int PlantTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(255)]
        public string TypeDescription { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [InverseProperty("PlantType")]
        public ICollection<tblPlants> tblPlants { get; set; }
    }
}
