using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblContracts
    {
        public tblContracts()
        {
            InverseParentContract = new HashSet<tblContracts>();
            tblCompanyOnboarding = new HashSet<tblCompanyOnboarding>();
            tblCompanySubContractors = new HashSet<tblCompanySubContractors>();
            tblContractAttachments = new HashSet<tblContractAttachments>();
            tblContractIntegrations = new HashSet<tblContractIntegrations>();
            tblContractProjects = new HashSet<tblContractProjects>();
        }

        [Key]
        public int ContractID { get; set; }
        [StringLength(120)]
        public string ContractNo { get; set; }
        public int? ParentContractID { get; set; }
        [StringLength(255)]
        public string ContractName { get; set; }
        public int? ContractTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractExecutionDate { get; set; }
        [StringLength(50)]
        public string ContractValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractEndDate { get; set; }
        public int? PrincipalID { get; set; }
        public int? CompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OriginalDocumentFiledDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DestructionDate { get; set; }
        public int? EntityID { get; set; }
        [StringLength(255)]
        public string PaymentTerm { get; set; }
        public bool? IsContractNumber { get; set; }
        public bool? ReleaseAndWaivers { get; set; }
        public int? CompanyOnBoardingID { get; set; }
        public int? ContractStatusID { get; set; }
        public int? DestructionYear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DefectsLiabilityPeriod { get; set; }
        public int? ContractSubStatusID { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblContracts")]
        public tblCompanies Company { get; set; }
        [ForeignKey("ContractStatusID")]
        [InverseProperty("tblContracts")]
        public tblContractStatuses ContractStatus { get; set; }
        [ForeignKey("ContractSubStatusID")]
        [InverseProperty("tblContracts")]
        public tblContractSubStatuses ContractSubStatus { get; set; }
        [ForeignKey("ContractTypeID")]
        [InverseProperty("tblContracts")]
        public tblContractTypes ContractType { get; set; }
        [ForeignKey("ParentContractID")]
        [InverseProperty("InverseParentContract")]
        public tblContracts ParentContract { get; set; }
        [ForeignKey("PrincipalID")]
        [InverseProperty("tblContracts")]
        public tblIndividuals Principal { get; set; }
        [InverseProperty("ParentContract")]
        public ICollection<tblContracts> InverseParentContract { get; set; }
        [InverseProperty("Contract")]
        public ICollection<tblCompanyOnboarding> tblCompanyOnboarding { get; set; }
        [InverseProperty("Contract")]
        public ICollection<tblCompanySubContractors> tblCompanySubContractors { get; set; }
        [InverseProperty("Contract")]
        public ICollection<tblContractAttachments> tblContractAttachments { get; set; }
        [InverseProperty("Contract")]
        public ICollection<tblContractIntegrations> tblContractIntegrations { get; set; }
        [InverseProperty("Contract")]
        public ICollection<tblContractProjects> tblContractProjects { get; set; }
    }
}
