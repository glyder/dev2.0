using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCapabilityGroups
    {
        public tblCapabilityGroups()
        {
            tblCapabilities = new HashSet<tblCapabilities>();
        }

        [Key]
        public int CapabilityGroupID { get; set; }
        [Required]
        [StringLength(120)]
        public string CapabilityGroup { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [InverseProperty("CapabilityGroup")]
        public ICollection<tblCapabilities> tblCapabilities { get; set; }
    }
}
