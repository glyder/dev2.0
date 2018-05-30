using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualProjects
    {
        [Key]
        public int IndividualProjectID { get; set; }
        public int ProjectID { get; set; }
        public int CompanyID { get; set; }
        public int IndividualID { get; set; }
        public int? IndividualProjectStatusID { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblIndividualProjects")]
        public tblCompanies Company { get; set; }
        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualProjects")]
        public tblIndividuals Individual { get; set; }
        [ForeignKey("IndividualProjectStatusID")]
        [InverseProperty("tblIndividualProjects")]
        public tblIndividualProjectStatuses IndividualProjectStatus { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblIndividualProjects")]
        public tblProjects Project { get; set; }
    }
}
