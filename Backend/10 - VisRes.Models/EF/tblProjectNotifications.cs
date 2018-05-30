using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectNotifications
    {
        [Key]
        public int ProjectNotificationID { get; set; }
        public int ProjectID { get; set; }
        public int NotificationID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("NotificationID")]
        [InverseProperty("tblProjectNotifications")]
        public tblNotifications Notification { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblProjectNotifications")]
        public tblProjects Project { get; set; }
    }
}
