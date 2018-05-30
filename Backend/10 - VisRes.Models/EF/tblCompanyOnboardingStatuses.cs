using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyOnboardingStatuses
    {
        public tblCompanyOnboardingStatuses()
        {
            tblCompanyOnboarding = new HashSet<tblCompanyOnboarding>();
        }

        [Key]
        public int CompanyOnboardingStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("CompanyOnboardingStatus")]
        public ICollection<tblCompanyOnboarding> tblCompanyOnboarding { get; set; }
    }
}
