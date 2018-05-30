using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompetencyNotifications
    {
        [Key]
        public int CompetencyNotificationID { get; set; }
        public int CompetencyID { get; set; }
        public int NotificationID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompetencyID")]
        [InverseProperty("tblCompetencyNotifications")]
        public tblCompetencies Competency { get; set; }
        [ForeignKey("NotificationID")]
        [InverseProperty("tblCompetencyNotifications")]
        public tblNotifications Notification { get; set; }
    }
}
