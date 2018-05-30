using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyCapabilities
    {
        [Key]
        public int CompanyCapabilityID { get; set; }
        public int CompanyID { get; set; }
        public int CapabilityID { get; set; }
        public string Comments { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [ForeignKey("CapabilityID")]
        [InverseProperty("tblCompanyCapabilities")]
        public tblCapabilities Capability { get; set; }
        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyCapabilities")]
        public tblCompanies Company { get; set; }
    }
}
