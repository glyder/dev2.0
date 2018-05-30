using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectCodes
    {
        public tblProjectCodes()
        {
            tblProjects = new HashSet<tblProjects>();
        }

        [Key]
        public int ProjectCodeID { get; set; }
        [Required]
        [StringLength(120)]
        public string ProjectCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [InverseProperty("ProjectCode")]
        public ICollection<tblProjects> tblProjects { get; set; }
    }
}
