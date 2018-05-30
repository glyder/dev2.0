using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblNotifications
    {
        public tblNotifications()
        {
            tblCompetencyNotifications = new HashSet<tblCompetencyNotifications>();
            tblInsuranceNotifications = new HashSet<tblInsuranceNotifications>();
            tblProjectNotifications = new HashSet<tblProjectNotifications>();
        }

        [Key]
        public int NotificationID { get; set; }
        public string Message { get; set; }
        public int? IndividualID { get; set; }
        public int? NotificationListID { get; set; }
        public int NotificationTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("IndividualID")]
        [InverseProperty("tblNotifications")]
        public tblIndividuals Individual { get; set; }
        [ForeignKey("NotificationListID")]
        [InverseProperty("tblNotifications")]
        public tblNotificationLists NotificationList { get; set; }
        [ForeignKey("NotificationTypeID")]
        [InverseProperty("tblNotifications")]
        public tblNotificationTypes NotificationType { get; set; }
        [InverseProperty("CompanyAccreditationNotification")]
        public tblCompanyAccreditationNotifications tblCompanyAccreditationNotifications { get; set; }
        [InverseProperty("Notification")]
        public ICollection<tblCompetencyNotifications> tblCompetencyNotifications { get; set; }
        [InverseProperty("Notification")]
        public ICollection<tblInsuranceNotifications> tblInsuranceNotifications { get; set; }
        [InverseProperty("Notification")]
        public ICollection<tblProjectNotifications> tblProjectNotifications { get; set; }
    }
}
