using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividuals
    {
        public tblIndividuals()
        {
            tblCompaniesAccountsPayableContact = new HashSet<tblCompanies>();
            tblCompaniesAccountsReceivableContact = new HashSet<tblCompanies>();
            tblCompaniesMainContact = new HashSet<tblCompanies>();
            tblCompanyIndividuals = new HashSet<tblCompanyIndividuals>();
            tblContracts = new HashSet<tblContracts>();
            tblIndividualAddresses = new HashSet<tblIndividualAddresses>();
            tblIndividualAttachments = new HashSet<tblIndividualAttachments>();
            tblIndividualComments = new HashSet<tblIndividualComments>();
            tblIndividualCompetencies = new HashSet<tblIndividualCompetencies>();
            tblIndividualIDCards = new HashSet<tblIndividualIDCards>();
            tblIndividualIndividualMainIndividual = new HashSet<tblIndividualIndividual>();
            tblIndividualIndividualRelatedIndividual = new HashSet<tblIndividualIndividual>();
            tblIndividualProjectRoles = new HashSet<tblIndividualProjectRoles>();
            tblIndividualProjects = new HashSet<tblIndividualProjects>();
            tblIndividualSuspensions = new HashSet<tblIndividualSuspensions>();
            tblNotificationListIndividuals = new HashSet<tblNotificationListIndividuals>();
            tblNotifications = new HashSet<tblNotifications>();
            tblProjects = new HashSet<tblProjects>();
        }

        [Key]
        public int IndividualID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string OtherName { get; set; }
        [StringLength(50)]
        public string PreferredName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateofBirth { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string MobileNumber { get; set; }
        [StringLength(120)]
        public string EMailAddress { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssuedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(20)]
        public string VentiaEmployeeID { get; set; }
        public int? AdvanceUserID { get; set; }
        public int? IndividualTypeID { get; set; }
        public int? IndividualStatusID { get; set; }
        public int IndividualSubStatusID { get; set; }

        [ForeignKey("IndividualID")]
        [InverseProperty("InverseIndividual")]
        public tblIndividuals Individual { get; set; }
        [ForeignKey("IndividualStatusID")]
        [InverseProperty("tblIndividuals")]
        public tblIndividualStatuses IndividualStatus { get; set; }
        [ForeignKey("IndividualSubStatusID")]
        [InverseProperty("tblIndividuals")]
        public tblIndividualSubStatuses IndividualSubStatus { get; set; }
        [ForeignKey("IndividualTypeID")]
        [InverseProperty("tblIndividuals")]
        public tblIndividualTypes IndividualType { get; set; }
        [InverseProperty("Individual")]
        public tblIndividuals InverseIndividual { get; set; }
        [InverseProperty("AccountsPayableContact")]
        public ICollection<tblCompanies> tblCompaniesAccountsPayableContact { get; set; }
        [InverseProperty("AccountsReceivableContact")]
        public ICollection<tblCompanies> tblCompaniesAccountsReceivableContact { get; set; }
        [InverseProperty("MainContact")]
        public ICollection<tblCompanies> tblCompaniesMainContact { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblCompanyIndividuals> tblCompanyIndividuals { get; set; }
        [InverseProperty("Principal")]
        public ICollection<tblContracts> tblContracts { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualAddresses> tblIndividualAddresses { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualAttachments> tblIndividualAttachments { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualComments> tblIndividualComments { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualCompetencies> tblIndividualCompetencies { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualIDCards> tblIndividualIDCards { get; set; }
        [InverseProperty("MainIndividual")]
        public ICollection<tblIndividualIndividual> tblIndividualIndividualMainIndividual { get; set; }
        [InverseProperty("RelatedIndividual")]
        public ICollection<tblIndividualIndividual> tblIndividualIndividualRelatedIndividual { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualProjectRoles> tblIndividualProjectRoles { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualProjects> tblIndividualProjects { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblIndividualSuspensions> tblIndividualSuspensions { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblNotificationListIndividuals> tblNotificationListIndividuals { get; set; }
        [InverseProperty("Individual")]
        public ICollection<tblNotifications> tblNotifications { get; set; }
        [InverseProperty("Manager")]
        public ICollection<tblProjects> tblProjects { get; set; }
    }
}
