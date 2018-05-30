using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanySubContractors
    {
        [Key]
        public int CompanySubContractorID { get; set; }
        public int SubContractorID { get; set; }
        public int CompanyID { get; set; }
        public string Comments { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public int? ContractID { get; set; }
        public int ProjectID { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanySubContractorsCompany")]
        public tblCompanies Company { get; set; }
        [ForeignKey("ContractID")]
        [InverseProperty("tblCompanySubContractors")]
        public tblContracts Contract { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblCompanySubContractors")]
        public tblProjects Project { get; set; }
        [ForeignKey("SubContractorID")]
        [InverseProperty("tblCompanySubContractorsSubContractor")]
        public tblCompanies SubContractor { get; set; }
    }
}
