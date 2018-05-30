using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblEOI
    {
        public tblEOI()
        {
            tblCompanyOnboarding = new HashSet<tblCompanyOnboarding>();
        }

        [Key]
        public int EOIID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int? ProjectID { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("ProjectID")]
        [InverseProperty("tblEOI")]
        public tblProjects Project { get; set; }
        [InverseProperty("EOI")]
        public ICollection<tblCompanyOnboarding> tblCompanyOnboarding { get; set; }
    }
}
