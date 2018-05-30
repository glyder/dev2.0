using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompanyAreasOfOperation
    {
        [Key]
        public int CompanyAreaOfOperationID { get; set; }
        public int CompanyID { get; set; }
        public int AreaOfOperationID { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("AreaOfOperationID")]
        [InverseProperty("tblCompanyAreasOfOperation")]
        public tblAreasOfOperation AreaOfOperation { get; set; }
        [ForeignKey("CompanyID")]
        [InverseProperty("tblCompanyAreasOfOperation")]
        public tblCompanies Company { get; set; }
    }
}
