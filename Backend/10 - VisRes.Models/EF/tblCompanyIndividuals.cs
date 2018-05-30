using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyIndividuals
    {
        [Key]
        public int CompanyIndividualID { get; set; }
        public int CompanyID { get; set; }
        public int IndividualID { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyIndividuals")]
        public tblCompanies Company { get; set; }
        [ForeignKey("IndividualID")]
        [InverseProperty("tblCompanyIndividuals")]
        public tblIndividuals Individual { get; set; }
    }
}
