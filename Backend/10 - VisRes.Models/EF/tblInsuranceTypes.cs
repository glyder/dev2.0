using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblInsuranceTypes
    {
        public tblInsuranceTypes()
        {
            tblInsurances = new HashSet<tblInsurances>();
        }

        [Key]
        public int InsuranceTypeID { get; set; }
        [Required]
        [StringLength(255)]
        public string Type { get; set; }
        public bool IsMandatory { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [InverseProperty("InsuranceType")]
        public ICollection<tblInsurances> tblInsurances { get; set; }
    }
}
