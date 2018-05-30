using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualSuspensions
    {
        [Key]
        public int IndividualSuspensionID { get; set; }
        public int SuspensionID { get; set; }
        public int IndividualID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualSuspensions")]
        public tblIndividuals Individual { get; set; }
        [ForeignKey("SuspensionID")]
        [InverseProperty("tblIndividualSuspensions")]
        public tblSuspensions Suspension { get; set; }
    }
}
