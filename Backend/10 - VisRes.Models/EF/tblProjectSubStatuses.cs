using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectSubStatuses
    {
        public tblProjectSubStatuses()
        {
            tblProjects = new HashSet<tblProjects>();
        }

        [Key]
        public int ProjectSubStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubStatus { get; set; }

        [InverseProperty("ProjectSubStatus")]
        public ICollection<tblProjects> tblProjects { get; set; }
    }
}
