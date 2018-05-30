using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblSuspensionReasons
    {
        public tblSuspensionReasons()
        {
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [Key]
        public int SuspensionReasonID { get; set; }
        [Required]
        [StringLength(120)]
        public string Reason { get; set; }

        [InverseProperty("SuspensionReason")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }
    }
}
