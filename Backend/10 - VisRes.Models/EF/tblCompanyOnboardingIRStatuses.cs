using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyOnboardingIRStatuses
    {
        [Key]
        public int CompanyOnboardingIRStatusID { get; set; }
        public int CompanyOnboardingID { get; set; }
        public int IRStatusID { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }

        [ForeignKey("CompanyOnboardingID")]
        [InverseProperty("tblCompanyOnboardingIRStatuses")]
        public tblCompanyOnboarding CompanyOnboarding { get; set; }
        [ForeignKey("IRStatusID")]
        [InverseProperty("tblCompanyOnboardingIRStatuses")]
        public tblIRStatuses IRStatus { get; set; }
    }
}
