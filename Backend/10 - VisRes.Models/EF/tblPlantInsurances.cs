using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblPlantInsurances
    {
        [Key]
        public int PlantInsuranceID { get; set; }
        public int PlantID { get; set; }
        public int InsuranceID { get; set; }

        [ForeignKey("InsuranceID")]
        [InverseProperty("tblPlantInsurances")]
        public tblInsurances Insurance { get; set; }
        [ForeignKey("PlantID")]
        [InverseProperty("tblPlantInsurances")]
        public tblPlants Plant { get; set; }
    }
}
