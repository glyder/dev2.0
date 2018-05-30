using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAreasOfOperation
    {
        public tblAreasOfOperation()
        {
            tblCompanyAreasOfOperation = new HashSet<tblCompanyAreasOfOperation>();
        }

        [Key]
        public int AreaOfOperationID { get; set; }
        public int? JurisdictionID { get; set; }
        [StringLength(50)]
        public string AreaCode { get; set; }
        [StringLength(50)]
        public string ExchangeName { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [ForeignKey("JurisdictionID")]
        [InverseProperty("tblAreasOfOperation")]
        public tblJurisdictions Jurisdiction { get; set; }
        [InverseProperty("AreaOfOperation")]
        public ICollection<tblCompanyAreasOfOperation> tblCompanyAreasOfOperation { get; set; }
    }
}
