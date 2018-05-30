using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyInsurances
    {
        [Key]
        public int CompanyInsuranceID { get; set; }
        public int CompanyID { get; set; }
        public int InsuranceID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyInsurances")]
        public tblCompanies Company { get; set; }
    }
}
