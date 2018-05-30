using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanySuspensions
    {
        [Key]
        public int CompanySuspensionID { get; set; }
        public int SuspensionID { get; set; }
        public int CompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanySuspensions")]
        public tblCompanies Company { get; set; }
        [ForeignKey("SuspensionID")]
        [InverseProperty("tblCompanySuspensions")]
        public tblSuspensions Suspension { get; set; }
    }
}
