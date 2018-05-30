using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyDueDiligence
    {
        [Key]
        public int CompanyDueDiligenceID { get; set; }
        public int CompanyID { get; set; }
        [Required]
        public string Answers { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyDueDiligence")]
        public tblCompanies Company { get; set; }
    }
}
