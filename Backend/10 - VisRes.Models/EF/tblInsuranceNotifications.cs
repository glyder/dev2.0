using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblInsuranceNotifications
    {
        [Key]
        public int InsuranceNotificationID { get; set; }
        public int InsuranceID { get; set; }
        public int NotificationID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("InsuranceID")]
        [InverseProperty("tblInsuranceNotifications")]
        public tblInsurances Insurance { get; set; }
        [ForeignKey("NotificationID")]
        [InverseProperty("tblInsuranceNotifications")]
        public tblNotifications Notification { get; set; }
    }
}
