using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblUserLevels
    {
        public tblUserLevels()
        {
            tblUsers = new HashSet<tblUsers>();
        }

        [Key]
        public int UserLevelID { get; set; }
        [Required]
        [StringLength(50)]
        public string UserLevel { get; set; }
        [Required]
        [StringLength(120)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }

        [InverseProperty("UserLevel")]
        public ICollection<tblUsers> tblUsers { get; set; }
    }
}
