using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblJurisdictions
    {
        public tblJurisdictions()
        {
            InverseParentJurisdiction = new HashSet<tblJurisdictions>();
            tblAreasOfOperation = new HashSet<tblAreasOfOperation>();
            tblCompetencyToJurisdiction = new HashSet<tblCompetencyToJurisdiction>();
            tblProjectJurisdictions = new HashSet<tblProjectJurisdictions>();
        }

        [Key]
        public int JurisdictionID { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        public int? ParentJurisdictionID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("ParentJurisdictionID")]
        [InverseProperty("InverseParentJurisdiction")]
        public tblJurisdictions ParentJurisdiction { get; set; }
        [InverseProperty("ParentJurisdiction")]
        public ICollection<tblJurisdictions> InverseParentJurisdiction { get; set; }
        [InverseProperty("Jurisdiction")]
        public ICollection<tblAreasOfOperation> tblAreasOfOperation { get; set; }
        [InverseProperty("Jurisdiction")]
        public ICollection<tblCompetencyToJurisdiction> tblCompetencyToJurisdiction { get; set; }
        [InverseProperty("Jurisdiction")]
        public ICollection<tblProjectJurisdictions> tblProjectJurisdictions { get; set; }
    }
}
