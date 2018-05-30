using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblSuspensionStatuses
    {
        public tblSuspensionStatuses()
        {
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [Key]
        public int SuspensionStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("SuspensionStatus")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }
    }
}
