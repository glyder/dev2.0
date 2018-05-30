using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblContractSubStatuses
    {
        public tblContractSubStatuses()
        {
            tblContracts = new HashSet<tblContracts>();
        }

        [Key]
        public int ContractSubStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubStatus { get; set; }

        [InverseProperty("ContractSubStatus")]
        public ICollection<tblContracts> tblContracts { get; set; }
    }
}
