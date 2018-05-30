using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblNotificationCategories
    {
        public tblNotificationCategories()
        {
            tblNotificationTypes = new HashSet<tblNotificationTypes>();
        }

        [Key]
        public int NotificationCategoryID { get; set; }
        [Required]
        [StringLength(255)]
        public string Category { get; set; }

        [InverseProperty("NotificationCategory")]
        public ICollection<tblNotificationTypes> tblNotificationTypes { get; set; }
    }
}
