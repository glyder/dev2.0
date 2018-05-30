using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyPlants
    {
        [Key]
        public int CompanyPlantID { get; set; }
        public int CompanyID { get; set; }
        public int PlantID { get; set; }
        public string Comments { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyPlants")]
        public tblCompanies Company { get; set; }
        [ForeignKey("PlantID")]
        [InverseProperty("tblCompanyPlants")]
        public tblPlants Plant { get; set; }
    }
}
