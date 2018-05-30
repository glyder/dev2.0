using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyTypes
    {
        public tblCompanyTypes()
        {
            tblCompanies = new HashSet<tblCompanies>();
        }

        [Key]
        public int CompanyTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [InverseProperty("CompanyType")]
        public ICollection<tblCompanies> tblCompanies { get; set; }
    }
}
