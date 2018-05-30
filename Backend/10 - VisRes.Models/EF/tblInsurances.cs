using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblInsurances
    {
        public tblInsurances()
        {
            tblInsuranceAttachments = new HashSet<tblInsuranceAttachments>();
            tblInsuranceNotifications = new HashSet<tblInsuranceNotifications>();
            tblPlantInsurances = new HashSet<tblPlantInsurances>();
        }

        [Key]
        public int InsuranceID { get; set; }
        public int InsuranceTypeID { get; set; }
        [StringLength(50)]
        public string PolicyNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(50)]
        public string AmountCover { get; set; }
        [StringLength(50)]
        public string ProviderName { get; set; }
        public int? DocAttahmentID { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public int? InsuranceSubStatusID { get; set; }
        public int CompanyID { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblInsurances")]
        public tblCompanies Company { get; set; }
        [ForeignKey("InsuranceSubStatusID")]
        [InverseProperty("tblInsurances")]
        public tblInsuranceSubStatuses InsuranceSubStatus { get; set; }
        [ForeignKey("InsuranceTypeID")]
        [InverseProperty("tblInsurances")]
        public tblInsuranceTypes InsuranceType { get; set; }
        [InverseProperty("Insurance")]
        public ICollection<tblInsuranceAttachments> tblInsuranceAttachments { get; set; }
        [InverseProperty("Insurance")]
        public ICollection<tblInsuranceNotifications> tblInsuranceNotifications { get; set; }
        [InverseProperty("Insurance")]
        public ICollection<tblPlantInsurances> tblPlantInsurances { get; set; }
    }
}
