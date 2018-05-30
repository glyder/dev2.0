using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Newtonsoft.Json;

namespace VisRes.Models.EF
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class tblProjects
    {
        public tblProjects()
        {
            tblCompanyAttachments = new HashSet<tblCompanyAttachments>();
            tblCompanySubContractors = new HashSet<tblCompanySubContractors>();
            tblContractProjects = new HashSet<tblContractProjects>();
            tblEOI = new HashSet<tblEOI>();
            tblIndividualIDCards = new HashSet<tblIndividualIDCards>();
            tblIndividualProjects = new HashSet<tblIndividualProjects>();
            tblProjectAddresses = new HashSet<tblProjectAddresses>();
            tblProjectAttachments = new HashSet<tblProjectAttachments>();
            tblProjectIntegrations = new HashSet<tblProjectIntegrations>();
            tblProjectJurisdictions = new HashSet<tblProjectJurisdictions>();
            tblProjectNotifications = new HashSet<tblProjectNotifications>();
            tblProjectRoles = new HashSet<tblProjectRoles>();
            tblSuspensions = new HashSet<tblSuspensions>();
            tblUserProjects = new HashSet<tblUserProjects>();
        }

        [JsonProperty]
        [Key]
        public int ProjectID { get; set; }

        [JsonProperty]
        [StringLength(255)]
        public string ProjectName { get; set; }

        [JsonProperty]
        public int? ManagerID { get; set; }

        public int? ProjectLogoAttachmentID { get; set; }

        [StringLength(50)]
        public string ProjectNumber { get; set; }

        [JsonProperty]
        [StringLength(50)]
        public string MobileNumber { get; set; }

        [JsonProperty]
        public int? LOBID { get; set; }

        [JsonProperty]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [JsonProperty]
        [StringLength(50)]
        public string FacsimileNumber { get; set; }

        [JsonProperty]
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [StringLength(150)]
        public string EditedBy { get; set; }

        [JsonProperty]
        public int? ProjectCodeID { get; set; }

        [StringLength(100)]
        public string ProjectManager { get; set; }

        [StringLength(50)]
        public string ProjectManagerNumber { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        public int? OrganisationId { get; set; }

        [StringLength(50)]
        public string OrganisationCode { get; set; }

        [StringLength(50)]
        public string ProjectStatus { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ProjectStartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ProjectCompletionDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        public int? ProjectSubStatusID { get; set; }


        [ForeignKey("LOBID")]
        [InverseProperty("tblProjects")]
        public tblLOBs LOB { get; set; }

        [ForeignKey("ManagerID")]
        [InverseProperty("tblProjects")]
        public tblIndividuals Manager { get; set; }

        [ForeignKey("OrganisationId")]
        [InverseProperty("tblProjects")]
        public tblCompanies Organisation { get; set; }

        [ForeignKey("ProjectCodeID")]
        [InverseProperty("tblProjects")]
        public tblProjectCodes ProjectCode { get; set; }

        [ForeignKey("ProjectSubStatusID")]
        [InverseProperty("tblProjects")]
        public tblProjectSubStatuses ProjectSubStatus { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblCompanyAttachments> tblCompanyAttachments { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblCompanySubContractors> tblCompanySubContractors { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblContractProjects> tblContractProjects { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblEOI> tblEOI { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblIndividualIDCards> tblIndividualIDCards { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblIndividualProjects> tblIndividualProjects { get; set; }


        [InverseProperty("Project")]
        public ICollection<tblProjectAddresses> tblProjectAddresses { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblProjectAttachments> tblProjectAttachments { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblProjectIntegrations> tblProjectIntegrations { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblProjectJurisdictions> tblProjectJurisdictions { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblProjectNotifications> tblProjectNotifications { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblProjectRoles> tblProjectRoles { get; set; }

        [InverseProperty("SuspendedProject")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }

        [InverseProperty("Project")]
        public ICollection<tblUserProjects> tblUserProjects { get; set; }
    }
}
