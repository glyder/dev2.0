using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblUserProjects
    {
        [Key]
        public int UserProjectID { get; set; }
        public int ProjectID { get; set; }
        public int UserID { get; set; }
        [Required]
        [StringLength(120)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }

        [ForeignKey("ProjectID")]
        [InverseProperty("tblUserProjects")]
        public tblProjects Project { get; set; }
        [ForeignKey("UserID")]
        [InverseProperty("tblUserProjects")]
        public tblUsers User { get; set; }
    }
}
