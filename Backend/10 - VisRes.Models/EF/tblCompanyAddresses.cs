using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyAddresses
    {
        [Key]
        public int CompanyAddressID { get; set; }
        public int CompanyID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("AddressID")]
        [InverseProperty("tblCompanyAddresses")]
        public tblAddresses Address { get; set; }
        [ForeignKey("AddressTypeID")]
        [InverseProperty("tblCompanyAddresses")]
        public tblAddressTypes AddressType { get; set; }
        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyAddresses")]
        public tblCompanies Company { get; set; }
    }
}
