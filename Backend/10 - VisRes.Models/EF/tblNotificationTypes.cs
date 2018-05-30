using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblNotificationTypes
    {
        public tblNotificationTypes()
        {
            tblNotifications = new HashSet<tblNotifications>();
        }

        [Key]
        public int NotificationTypeID { get; set; }
        [Required]
        [StringLength(255)]
        public string Type { get; set; }
        public int NotificationCategoryID { get; set; }

        [ForeignKey("NotificationCategoryID")]
        [InverseProperty("tblNotificationTypes")]
        public tblNotificationCategories NotificationCategory { get; set; }
        [InverseProperty("NotificationType")]
        public ICollection<tblNotifications> tblNotifications { get; set; }
    }
}
