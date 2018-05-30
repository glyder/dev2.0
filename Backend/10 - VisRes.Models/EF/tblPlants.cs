using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblPlants
    {
        public tblPlants()
        {
            tblCompanyPlants = new HashSet<tblCompanyPlants>();
            tblPlantAttachments = new HashSet<tblPlantAttachments>();
            tblPlantComments = new HashSet<tblPlantComments>();
            tblPlantInsurances = new HashSet<tblPlantInsurances>();
            tblPlantSuspensions = new HashSet<tblPlantSuspensions>();
        }

        [Key]
        public int PlantID { get; set; }
        [StringLength(50)]
        public string PlantName { get; set; }
        [StringLength(255)]
        public string PlantDescription { get; set; }
        [StringLength(50)]
        public string PlantMake { get; set; }
        [StringLength(50)]
        public string PlantModel { get; set; }
        [StringLength(50)]
        public string VIN { get; set; }
        [StringLength(10)]
        public string YearOfManufacture { get; set; }
        [StringLength(50)]
        public string RegistrationNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RegistrationExpiry { get; set; }
        [StringLength(50)]
        public string BaseLocation { get; set; }
        [StringLength(50)]
        public string CurrentLocation { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? CanMobilise { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public int PlantTypeID { get; set; }
        public int CompanyID { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblPlants")]
        public tblCompanies Company { get; set; }
        [ForeignKey("PlantTypeID")]
        [InverseProperty("tblPlants")]
        public tblPlantTypes PlantType { get; set; }
        [InverseProperty("Plant")]
        public ICollection<tblCompanyPlants> tblCompanyPlants { get; set; }
        [InverseProperty("Plant")]
        public ICollection<tblPlantAttachments> tblPlantAttachments { get; set; }
        [InverseProperty("Plant")]
        public ICollection<tblPlantComments> tblPlantComments { get; set; }
        [InverseProperty("Plant")]
        public ICollection<tblPlantInsurances> tblPlantInsurances { get; set; }
        [InverseProperty("Plant")]
        public ICollection<tblPlantSuspensions> tblPlantSuspensions { get; set; }
    }
}
