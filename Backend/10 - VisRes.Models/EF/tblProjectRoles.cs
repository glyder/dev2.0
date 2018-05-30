using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectRoles
    {
        public tblProjectRoles()
        {
            tblDefaultProjectRoles = new HashSet<tblDefaultProjectRoles>();
            tblIndividualProjectRoles = new HashSet<tblIndividualProjectRoles>();
            tblProjectRoleScores = new HashSet<tblProjectRoleScores>();
            tblProjectRoleToCompetency = new HashSet<tblProjectRoleToCompetency>();
            tblProjectRoleToRoleLibrary = new HashSet<tblProjectRoleToRoleLibrary>();
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [Key]
        public int ProjectRoleID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("ProjectID")]
        [InverseProperty("tblProjectRoles")]
        public tblProjects Project { get; set; }
        [InverseProperty("ProjectRole")]
        public ICollection<tblDefaultProjectRoles> tblDefaultProjectRoles { get; set; }
        [InverseProperty("ProjectRole")]
        public ICollection<tblIndividualProjectRoles> tblIndividualProjectRoles { get; set; }
        [InverseProperty("ProjectRole")]
        public ICollection<tblProjectRoleScores> tblProjectRoleScores { get; set; }
        [InverseProperty("ProjectRole")]
        public ICollection<tblProjectRoleToCompetency> tblProjectRoleToCompetency { get; set; }
        [InverseProperty("ProjectRole")]
        public ICollection<tblProjectRoleToRoleLibrary> tblProjectRoleToRoleLibrary { get; set; }
        [InverseProperty("SuspendedProjectRole")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }
    }
}
