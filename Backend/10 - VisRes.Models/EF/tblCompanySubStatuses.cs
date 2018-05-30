using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanySubStatuses
    {
        public tblCompanySubStatuses()
        {
            tblCompanies = new HashSet<tblCompanies>();
        }

        [Key]
        public int CompanySubStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubStatus { get; set; }

        [InverseProperty("CompanySubStatus")]
        public ICollection<tblCompanies> tblCompanies { get; set; }
    }
}
