
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Newtonsoft.Json;

namespace VisRes.Models.EF
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class tblLOBs
    {
        public tblLOBs()
        {
            tblProjects = new HashSet<tblProjects>();
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [JsonProperty]
        [Key]
        [Column("LOBID")]
        public int LOBID { get; set; }

        [JsonProperty]
        [Required]
        [Column("LOB")]
        [StringLength(120)]
        public string LOB { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        [StringLength(150)]
        public string EditedBy { get; set; }

        public int DivisionID { get; set; }

        [ForeignKey("DivisionID")]
        [InverseProperty("tblLOBs")]
        public tblDivisions Division { get; set; }

        [InverseProperty("LOB")]
        public ICollection<tblProjects> tblProjects { get; set; }

        [InverseProperty("SuspendedLOB")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }


    }
}
