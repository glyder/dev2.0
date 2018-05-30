using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblNotificationListIndividuals
    {
        [Key]
        public int NotificationListIndividualID { get; set; }
        public int NotificationListID { get; set; }
        public int IndividualID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("IndividualID")]
        [InverseProperty("tblNotificationListIndividuals")]
        public tblIndividuals Individual { get; set; }
    }
}
