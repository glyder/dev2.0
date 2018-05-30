using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyOnboardingSHEQStatuses
    {
        [Key]
        public int CompanyOnboardingSHEQStatusID { get; set; }
        public int CompanyOnboardingID { get; set; }
        public int SHEQStatusID { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }

        [ForeignKey("CompanyOnboardingID")]
        [InverseProperty("tblCompanyOnboardingSHEQStatuses")]
        public tblCompanyOnboarding CompanyOnboarding { get; set; }
        [ForeignKey("SHEQStatusID")]
        [InverseProperty("tblCompanyOnboardingSHEQStatuses")]
        public tblSHEQStatuses SHEQStatus { get; set; }
    }
}
