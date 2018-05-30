using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblInsuranceSubStatuses
    {
        public tblInsuranceSubStatuses()
        {
            tblInsurances = new HashSet<tblInsurances>();
        }

        [Key]
        public int InsuranceSubStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubStatus { get; set; }

        [InverseProperty("InsuranceSubStatus")]
        public ICollection<tblInsurances> tblInsurances { get; set; }
    }
}
