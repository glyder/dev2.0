using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblContractIntegrations
    {
        [Key]
        public int ContractIntegrationID { get; set; }
        public int ContractID { get; set; }
        [Required]
        [StringLength(255)]
        public string IntegratedSystem { get; set; }
        [Required]
        [StringLength(255)]
        public string Key { get; set; }
        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        [ForeignKey("ContractID")]
        [InverseProperty("tblContractIntegrations")]
        public tblContracts Contract { get; set; }
    }
}
