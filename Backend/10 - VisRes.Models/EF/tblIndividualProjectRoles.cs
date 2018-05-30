using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualProjectRoles
    {
        [Key]
        public int IndividualProjectRoleID { get; set; }
        public int IndividualID { get; set; }
        public int ProjectRoleID { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualProjectRoles")]
        public tblIndividuals Individual { get; set; }
        [ForeignKey("ProjectRoleID")]
        [InverseProperty("tblIndividualProjectRoles")]
        public tblProjectRoles ProjectRole { get; set; }
    }
}
