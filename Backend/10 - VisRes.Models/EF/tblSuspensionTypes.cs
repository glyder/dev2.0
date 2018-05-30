using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblSuspensionTypes
    {
        public tblSuspensionTypes()
        {
            tblSuspensions = new HashSet<tblSuspensions>();
        }

        [Key]
        public int SuspensionTypeID { get; set; }
        [Required]
        [StringLength(120)]
        public string Type { get; set; }

        [InverseProperty("SuspensionType")]
        public ICollection<tblSuspensions> tblSuspensions { get; set; }
    }
}
