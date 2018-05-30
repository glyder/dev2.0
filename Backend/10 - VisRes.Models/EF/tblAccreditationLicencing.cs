using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblAccreditationLicencing
    {
        public tblAccreditationLicencing()
        {
            tblCompanyAccreditations = new HashSet<tblCompanyAccreditations>();
        }

        [Key]
        public int AccreditationLicencingID { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [InverseProperty("AccreditationLicencing")]
        public ICollection<tblCompanyAccreditations> tblCompanyAccreditations { get; set; }
    }
}
