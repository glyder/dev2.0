using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblContractStatuses
    {
        public tblContractStatuses()
        {
            tblContracts = new HashSet<tblContracts>();
        }

        [Key]
        public int ContractStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("ContractStatus")]
        public ICollection<tblContracts> tblContracts { get; set; }
    }
}
