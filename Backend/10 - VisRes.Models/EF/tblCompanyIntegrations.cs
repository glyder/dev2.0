using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyIntegrations
    {
        [Key]
        public int CompanyIntegrationID { get; set; }
        public int CompanyID { get; set; }
        [Required]
        [StringLength(255)]
        public string IntegratedSystem { get; set; }
        [Required]
        [StringLength(255)]
        public string Key { get; set; }
        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyIntegrations")]
        public tblCompanies Company { get; set; }
    }
}
