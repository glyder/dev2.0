using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblCompetencies
    {
        public tblCompetencies()
        {
            InverseParentCompetency = new HashSet<tblCompetencies>();
            tblAlternativeCompetenciesCanBeReplacedByCompetencyNavigation = new HashSet<tblAlternativeCompetencies>();
            tblAlternativeCompetenciesCompetency = new HashSet<tblAlternativeCompetencies>();
            tblCompetencyIntegrations = new HashSet<tblCompetencyIntegrations>();
            tblCompetencyNotifications = new HashSet<tblCompetencyNotifications>();
            tblCompetencyScores = new HashSet<tblCompetencyScores>();
            tblCompetencyToJurisdiction = new HashSet<tblCompetencyToJurisdiction>();
            tblCompetencyToRCGroup = new HashSet<tblCompetencyToRCGroup>();
            tblIndividualCompetencies = new HashSet<tblIndividualCompetencies>();
            tblProjectRoleToCompetency = new HashSet<tblProjectRoleToCompetency>();
            tblRoleToCompetency = new HashSet<tblRoleToCompetency>();
        }

        [Key]
        public int CompetencyID { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompetencyTypeID { get; set; }
        public int? ParentCompetencyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("CompetencyTypeID")]
        [InverseProperty("tblCompetencies")]
        public tblCompetencyTypes CompetencyType { get; set; }
        [ForeignKey("ParentCompetencyID")]
        [InverseProperty("InverseParentCompetency")]
        public tblCompetencies ParentCompetency { get; set; }
        [InverseProperty("ParentCompetency")]
        public ICollection<tblCompetencies> InverseParentCompetency { get; set; }
        [InverseProperty("CanBeReplacedByCompetencyNavigation")]
        public ICollection<tblAlternativeCompetencies> tblAlternativeCompetenciesCanBeReplacedByCompetencyNavigation { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblAlternativeCompetencies> tblAlternativeCompetenciesCompetency { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblCompetencyIntegrations> tblCompetencyIntegrations { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblCompetencyNotifications> tblCompetencyNotifications { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblCompetencyScores> tblCompetencyScores { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblCompetencyToJurisdiction> tblCompetencyToJurisdiction { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblCompetencyToRCGroup> tblCompetencyToRCGroup { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblIndividualCompetencies> tblIndividualCompetencies { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblProjectRoleToCompetency> tblProjectRoleToCompetency { get; set; }
        [InverseProperty("Competency")]
        public ICollection<tblRoleToCompetency> tblRoleToCompetency { get; set; }
    }
}
