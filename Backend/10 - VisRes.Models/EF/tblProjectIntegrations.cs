using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectIntegrations
    {
        [Key]
        public int ProjectIntegrationID { get; set; }
        public int ProjectID { get; set; }
        [Required]
        [StringLength(255)]
        public string IntegratedSystem { get; set; }
        [Required]
        [StringLength(255)]
        public string Key { get; set; }
        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        [ForeignKey("ProjectID")]
        [InverseProperty("tblProjectIntegrations")]
        public tblProjects Project { get; set; }
    }
}
