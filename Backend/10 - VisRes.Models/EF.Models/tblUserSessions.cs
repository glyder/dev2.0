using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblUserSessions
    {
        // [Key]
        public int ID { get; set; }

        [Column("UserID")]
        public int UserID { get; set; }

        [Required]
        public string SessionAttribute { get; set; }

        [ForeignKey("UserID")]
        [InverseProperty("tblUserSessions")]
        public tblUsers User { get; set; }
    }
}
