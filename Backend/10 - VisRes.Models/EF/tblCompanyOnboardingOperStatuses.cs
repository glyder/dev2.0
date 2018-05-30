using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyOnboardingOperStatuses
    {
        [Key]
        public int CompanyOnboardingOperStatusID { get; set; }
        public int CompanyOnboardingID { get; set; }
        public int OperStatusID { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }

        [ForeignKey("CompanyOnboardingID")]
        [InverseProperty("tblCompanyOnboardingOperStatuses")]
        public tblCompanyOnboarding CompanyOnboarding { get; set; }
        [ForeignKey("OperStatusID")]
        [InverseProperty("tblCompanyOnboardingOperStatuses")]
        public tblOperStatuses OperStatus { get; set; }
    }
}
