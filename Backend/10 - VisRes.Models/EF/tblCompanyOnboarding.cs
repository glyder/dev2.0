using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyOnboarding
    {
        public tblCompanyOnboarding()
        {
            tblCompanyOnboardingAttachments = new HashSet<tblCompanyOnboardingAttachments>();
            tblCompanyOnboardingIRStatuses = new HashSet<tblCompanyOnboardingIRStatuses>();
            tblCompanyOnboardingOperStatuses = new HashSet<tblCompanyOnboardingOperStatuses>();
            tblCompanyOnboardingSHEQStatuses = new HashSet<tblCompanyOnboardingSHEQStatuses>();
        }

        [Key]
        public int CompanyOnboardingID { get; set; }
        public int CompanyID { get; set; }
        public int? EOIID { get; set; }
        public int CompanyOnboardingStatusID { get; set; }
        public int? ContractID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyOnboarding")]
        public tblCompanies Company { get; set; }
        [ForeignKey("CompanyOnboardingStatusID")]
        [InverseProperty("tblCompanyOnboarding")]
        public tblCompanyOnboardingStatuses CompanyOnboardingStatus { get; set; }
        [ForeignKey("ContractID")]
        [InverseProperty("tblCompanyOnboarding")]
        public tblContracts Contract { get; set; }
        [ForeignKey("EOIID")]
        [InverseProperty("tblCompanyOnboarding")]
        public tblEOI EOI { get; set; }
        [InverseProperty("CompanyOnboarding")]
        public ICollection<tblCompanyOnboardingAttachments> tblCompanyOnboardingAttachments { get; set; }
        [InverseProperty("CompanyOnboarding")]
        public ICollection<tblCompanyOnboardingIRStatuses> tblCompanyOnboardingIRStatuses { get; set; }
        [InverseProperty("CompanyOnboarding")]
        public ICollection<tblCompanyOnboardingOperStatuses> tblCompanyOnboardingOperStatuses { get; set; }
        [InverseProperty("CompanyOnboarding")]
        public ICollection<tblCompanyOnboardingSHEQStatuses> tblCompanyOnboardingSHEQStatuses { get; set; }
    }
}
