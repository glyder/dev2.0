using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblLOBs
    {
        public tblLOBs()
        {
            tblProjects = new HashSet<tblProjects>();
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [Key]
        public int LOBID { get; set; }
        [Required]
        [StringLength(120)]
        public string LOB { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        public int DivisionID { get; set; }

        [ForeignKey("DivisionID")]
        [InverseProperty("tblLOBs")]
        public tblDivisions Division { get; set; }
        [InverseProperty("LOB")]
        public ICollection<tblProjects> tblProjects { get; set; }
        [InverseProperty("SuspendedLOB")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }
    }
}
