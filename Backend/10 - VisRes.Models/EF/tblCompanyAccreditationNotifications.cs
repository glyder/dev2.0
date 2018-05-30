using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyAccreditationNotifications
    {
        [Key]
        public int CompanyAccreditationNotificationID { get; set; }
        public int CompanyAccreditationID { get; set; }
        public int NotificationID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompanyAccreditationID")]
        [InverseProperty("tblCompanyAccreditationNotifications")]
        public tblCompanyAccreditations CompanyAccreditation { get; set; }
        [ForeignKey("CompanyAccreditationNotificationID")]
        [InverseProperty("tblCompanyAccreditationNotifications")]
        public tblNotifications CompanyAccreditationNotification { get; set; }
    }
}
