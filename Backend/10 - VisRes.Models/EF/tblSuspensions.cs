using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblSuspensions
    {
        public tblSuspensions()
        {
            tblCompanySuspensions = new HashSet<tblCompanySuspensions>();
            tblIndividualSuspensions = new HashSet<tblIndividualSuspensions>();
            tblPlantSuspensions = new HashSet<tblPlantSuspensions>();
            tblProviderSuspensions = new HashSet<tblProviderSuspensions>();
            tblSuspensionNotes = new HashSet<tblSuspensionNotes>();
        }

        [Key]
        public int SuspensionID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int SuspensionTypeID { get; set; }
        public int? SuspensionReasonID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SuspensionStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SuspensionEndDate { get; set; }
        public int? SuspendedProjectID { get; set; }
        public int? SuspendedProjectRoleID { get; set; }
        public int? SuspendedLOBID { get; set; }
        public int? SuspendedDivisionID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        public int? SuspendedCapabilityID { get; set; }
        public int SuspensionStatusID { get; set; }

        [ForeignKey("SuspendedCapabilityID")]
        [InverseProperty("tblSuspensions")]
        public tblCapabilities SuspendedCapability { get; set; }
        [ForeignKey("SuspendedDivisionID")]
        [InverseProperty("tblSuspensions")]
        public tblDivisions SuspendedDivision { get; set; }
        [ForeignKey("SuspendedLOBID")]
        [InverseProperty("tblSuspensions")]
        public tblLOBs SuspendedLOB { get; set; }
        [ForeignKey("SuspendedProjectID")]
        [InverseProperty("tblSuspensions")]
        public tblProjects SuspendedProject { get; set; }
        [ForeignKey("SuspendedProjectRoleID")]
        [InverseProperty("tblSuspensions")]
        public tblProjectRoles SuspendedProjectRole { get; set; }
        [ForeignKey("SuspensionReasonID")]
        [InverseProperty("tblSuspensions")]
        public tblSuspensionReasons SuspensionReason { get; set; }
        [ForeignKey("SuspensionStatusID")]
        [InverseProperty("tblSuspensions")]
        public tblSuspensionStatuses SuspensionStatus { get; set; }
        [ForeignKey("SuspensionTypeID")]
        [InverseProperty("tblSuspensions")]
        public tblSuspensionTypes SuspensionType { get; set; }
        [InverseProperty("Suspension")]
        public ICollection<tblCompanySuspensions> tblCompanySuspensions { get; set; }
        [InverseProperty("Suspension")]
        public ICollection<tblIndividualSuspensions> tblIndividualSuspensions { get; set; }
        [InverseProperty("Suspension")]
        public ICollection<tblPlantSuspensions> tblPlantSuspensions { get; set; }
        [InverseProperty("Suspension")]
        public ICollection<tblProviderSuspensions> tblProviderSuspensions { get; set; }
        [InverseProperty("Suspension")]
        public ICollection<tblSuspensionNotes> tblSuspensionNotes { get; set; }
    }
}
