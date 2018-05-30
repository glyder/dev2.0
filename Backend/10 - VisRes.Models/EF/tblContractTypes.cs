using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblContractTypes
    {
        public tblContractTypes()
        {
            tblContracts = new HashSet<tblContracts>();
        }

        [Key]
        public int ContractTypeID { get; set; }
        [Required]
        [StringLength(250)]
        public string Type { get; set; }

        [InverseProperty("ContractType")]
        public ICollection<tblContracts> tblContracts { get; set; }
    }
}
