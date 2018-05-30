using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyAccreditations
    {
        public tblCompanyAccreditations()
        {
            tblCompanyAccreditationAttachments = new HashSet<tblCompanyAccreditationAttachments>();
            tblCompanyAccreditationNotifications = new HashSet<tblCompanyAccreditationNotifications>();
        }

        [Key]
        public int CompanyAccreditationID { get; set; }
        public int CompanyID { get; set; }
        public int AccreditationLicencingID { get; set; }
        public int? IssuedID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAchieved { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(50)]
        public string LicenceNumber { get; set; }
        public string Comments { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public int? StateID { get; set; }

        [ForeignKey("AccreditationLicencingID")]
        [InverseProperty("tblCompanyAccreditations")]
        public tblAccreditationLicencing AccreditationLicencing { get; set; }
        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyAccreditations")]
        public tblCompanies Company { get; set; }
        [InverseProperty("CompanyAccreditation")]
        public ICollection<tblCompanyAccreditationAttachments> tblCompanyAccreditationAttachments { get; set; }
        [InverseProperty("CompanyAccreditation")]
        public ICollection<tblCompanyAccreditationNotifications> tblCompanyAccreditationNotifications { get; set; }
    }
}
