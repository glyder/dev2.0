using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCapabilities
    {
        public tblCapabilities()
        {
            tblCompanyCapabilities = new HashSet<tblCompanyCapabilities>();
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [Key]
        public int CapabilityID { get; set; }
        [Required]
        [StringLength(120)]
        public string Capability { get; set; }
        [StringLength(120)]
        public string SubCapability { get; set; }
        public int? CapabilityGroupID { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [ForeignKey("CapabilityGroupID")]
        [InverseProperty("tblCapabilities")]
        public tblCapabilityGroups CapabilityGroup { get; set; }
        [InverseProperty("Capability")]
        public ICollection<tblCompanyCapabilities> tblCompanyCapabilities { get; set; }
        [InverseProperty("SuspendedCapability")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }
    }
}
