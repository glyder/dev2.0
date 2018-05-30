using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class tblCompanies
    {
        public tblCompanies()
        {
            tblCompanyAccreditations = new HashSet<tblCompanyAccreditations>();
            tblCompanyAddresses = new HashSet<tblCompanyAddresses>();
            tblCompanyAreasOfOperation = new HashSet<tblCompanyAreasOfOperation>();
            tblCompanyAttachments = new HashSet<tblCompanyAttachments>();
            tblCompanyCapabilities = new HashSet<tblCompanyCapabilities>();
            tblCompanyComments = new HashSet<tblCompanyComments>();
            tblCompanyDueDiligence = new HashSet<tblCompanyDueDiligence>();
            tblCompanyIndividuals = new HashSet<tblCompanyIndividuals>();
            tblCompanyInsurances = new HashSet<tblCompanyInsurances>();
            tblCompanyIntegrations = new HashSet<tblCompanyIntegrations>();
            tblCompanyOnboarding = new HashSet<tblCompanyOnboarding>();
            tblCompanyPlants = new HashSet<tblCompanyPlants>();
            tblCompanySubContractorsCompany = new HashSet<tblCompanySubContractors>();
            tblCompanySubContractorsSubContractor = new HashSet<tblCompanySubContractors>();
            tblCompanySuspensions = new HashSet<tblCompanySuspensions>();
            tblContracts = new HashSet<tblContracts>();
            tblDefaultProjectRoles = new HashSet<tblDefaultProjectRoles>();
            tblIndividualCompetencies = new HashSet<tblIndividualCompetencies>();
            tblIndividualIDCards = new HashSet<tblIndividualIDCards>();
            tblIndividualProjects = new HashSet<tblIndividualProjects>();
            tblInsurances = new HashSet<tblInsurances>();
            tblPlants = new HashSet<tblPlants>();
            tblProjects = new HashSet<tblProjects>();
            tblProviderSuspensions = new HashSet<tblProviderSuspensions>();
        }


        [JsonProperty]
        [Key]
        public int CompanyID { get; set; }


        [JsonProperty]
        [Required]
        [StringLength(255)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string TradingName { get; set; }

        public int? CompanyTypeID { get; set; }

        public int? MainContactID { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string MobileNumber { get; set; }

        [StringLength(50)]
        public string FacsimileNumber { get; set; }

        [StringLength(255)]
        public string EMailAddress { get; set; }

        [StringLength(50)]
        public string ABN { get; set; }

        [StringLength(50)]
        public string ACN { get; set; }

        public int? AccountsReceivableContactID { get; set; }

        public int? AccountsPayableContactID { get; set; }

        [StringLength(150)]
        public string EditedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        public int? VENDOR_ID { get; set; }

        [StringLength(20)]
        public string SEGMENT1 { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? LAST_UPDATE_DATE { get; set; }

        public int? VENDOR_SITE_ID { get; set; }

        [StringLength(255)]
        public string VENDOR_SITE_CODE { get; set; }

        public string ADDRESS_LINE3 { get; set; }

        [StringLength(25)]
        public string OPERATING_UNIT { get; set; }

        [StringLength(50)]
        public string CustomerNumber { get; set; }

        public int? CustomerSite { get; set; }

        public int? AdvanceCompanyID { get; set; }

        public int? CompanyStatusID { get; set; }

        public int? DivisionID { get; set; }

        public int? CountryID { get; set; }

        [StringLength(50)]
        public string RTONumber { get; set; }

        public int CompanySubStatusID { get; set; }

        [ForeignKey("AccountsPayableContactID")]
        [InverseProperty("tblCompaniesAccountsPayableContact")]
        public tblIndividuals AccountsPayableContact { get; set; }

        [ForeignKey("AccountsReceivableContactID")]
        [InverseProperty("tblCompaniesAccountsReceivableContact")]
        public tblIndividuals AccountsReceivableContact { get; set; }

        [ForeignKey("CompanySubStatusID")]
        [InverseProperty("tblCompanies")]
        public tblCompanySubStatuses CompanySubStatus { get; set; }

        [ForeignKey("CompanyTypeID")]
        [InverseProperty("tblCompanies")]
        public tblCompanyTypes CompanyType { get; set; }

        [ForeignKey("CountryID")]
        [InverseProperty("tblCompanies")]
        public tblCountries Country { get; set; }

        [ForeignKey("DivisionID")]
        [InverseProperty("tblCompanies")]
        public tblDivisions Division { get; set; }

        [ForeignKey("MainContactID")]
        [InverseProperty("tblCompaniesMainContact")]
        public tblIndividuals MainContact { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyAccreditations> tblCompanyAccreditations { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyAddresses> tblCompanyAddresses { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyAreasOfOperation> tblCompanyAreasOfOperation { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyAttachments> tblCompanyAttachments { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyCapabilities> tblCompanyCapabilities { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyComments> tblCompanyComments { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyDueDiligence> tblCompanyDueDiligence { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyIndividuals> tblCompanyIndividuals { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyInsurances> tblCompanyInsurances { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyIntegrations> tblCompanyIntegrations { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyOnboarding> tblCompanyOnboarding { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanyPlants> tblCompanyPlants { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanySubContractors> tblCompanySubContractorsCompany { get; set; }

        [InverseProperty("SubContractor")]
        public ICollection<tblCompanySubContractors> tblCompanySubContractorsSubContractor { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblCompanySuspensions> tblCompanySuspensions { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblContracts> tblContracts { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblDefaultProjectRoles> tblDefaultProjectRoles { get; set; }

        [InverseProperty("Provider")]
        public ICollection<tblIndividualCompetencies> tblIndividualCompetencies { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblIndividualIDCards> tblIndividualIDCards { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblIndividualProjects> tblIndividualProjects { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblInsurances> tblInsurances { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblPlants> tblPlants { get; set; }

        [InverseProperty("Organisation")]
        public ICollection<tblProjects> tblProjects { get; set; }

        [InverseProperty("Company")]
        public ICollection<tblProviderSuspensions> tblProviderSuspensions { get; set; }


    }
}
