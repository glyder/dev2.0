using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAddressTypes
    {
        public tblAddressTypes()
        {
            tblCompanyAddresses = new HashSet<tblCompanyAddresses>();
            tblIndividualAddresses = new HashSet<tblIndividualAddresses>();
            tblProjectAddresses = new HashSet<tblProjectAddresses>();
        }

        [Key]
        public int AddressTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [InverseProperty("AddressType")]
        public ICollection<tblCompanyAddresses> tblCompanyAddresses { get; set; }
        [InverseProperty("AddressType")]
        public ICollection<tblIndividualAddresses> tblIndividualAddresses { get; set; }
        [InverseProperty("AddressType")]
        public ICollection<tblProjectAddresses> tblProjectAddresses { get; set; }
    }
}
