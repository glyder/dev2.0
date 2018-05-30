using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblNotificationLists
    {
        public tblNotificationLists()
        {
            tblNotifications = new HashSet<tblNotifications>();
        }

        [Key]
        public int NotificationListID { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        public int NotificationTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [InverseProperty("NotificationList")]
        public ICollection<tblNotifications> tblNotifications { get; set; }
    }
}
