using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCountries
    {
        public tblCountries()
        {
            tblAddresses = new HashSet<tblAddresses>();
            tblCompanies = new HashSet<tblCompanies>();
            tblStates = new HashSet<tblStates>();
        }

        [Key]
        public int CountryID { get; set; }
        [Required]
        [StringLength(255)]
        public string Country { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(50)]
        public string CountryCode { get; set; }
        public int? SortOrder { get; set; }

        [InverseProperty("Country")]
        public ICollection<tblAddresses> tblAddresses { get; set; }
        [InverseProperty("Country")]
        public ICollection<tblCompanies> tblCompanies { get; set; }
        [InverseProperty("Country")]
        public ICollection<tblStates> tblStates { get; set; }
    }
}
