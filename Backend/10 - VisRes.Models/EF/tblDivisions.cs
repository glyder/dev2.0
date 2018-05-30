using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblDivisions
    {
        public tblDivisions()
        {
            tblCompanies = new HashSet<tblCompanies>();
            tblLOBs = new HashSet<tblLOBs>();
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [Key]
        public int DivisionID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int? BrandingID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [InverseProperty("Division")]
        public ICollection<tblCompanies> tblCompanies { get; set; }
        [InverseProperty("Division")]
        public ICollection<tblLOBs> tblLOBs { get; set; }
        [InverseProperty("SuspendedDivision")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }
    }
}
