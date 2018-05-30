using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAddresses
    {
        public tblAddresses()
        {
            tblCompanyAddresses = new HashSet<tblCompanyAddresses>();
            tblIndividualAddresses = new HashSet<tblIndividualAddresses>();
            tblProjectAddresses = new HashSet<tblProjectAddresses>();
        }

        [Key]
        public int AddressID { get; set; }
        [StringLength(120)]
        public string AddressLine1 { get; set; }
        [StringLength(120)]
        public string AddressLine2 { get; set; }
        [StringLength(120)]
        public string AddressLine3 { get; set; }
        [StringLength(50)]
        public string Suburb { get; set; }
        public int? StateID { get; set; }
        [StringLength(50)]
        public string PostCode { get; set; }
        public int CountryID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CountryID")]
        [InverseProperty("tblAddresses")]
        public tblCountries Country { get; set; }
        [ForeignKey("StateID")]
        [InverseProperty("tblAddresses")]
        public tblStates State { get; set; }
        [InverseProperty("Address")]
        public ICollection<tblCompanyAddresses> tblCompanyAddresses { get; set; }
        [InverseProperty("Address")]
        public ICollection<tblIndividualAddresses> tblIndividualAddresses { get; set; }
        [InverseProperty("Address")]
        public ICollection<tblProjectAddresses> tblProjectAddresses { get; set; }
    }
}
