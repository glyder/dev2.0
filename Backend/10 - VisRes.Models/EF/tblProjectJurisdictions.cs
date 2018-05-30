using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectJurisdictions
    {
        [Key]
        public int ProjectJurisdictionID { get; set; }
        public int ProjectID { get; set; }
        public int JurisdictionID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("JurisdictionID")]
        [InverseProperty("tblProjectJurisdictions")]
        public tblJurisdictions Jurisdiction { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblProjectJurisdictions")]
        public tblProjects Project { get; set; }
    }
}
