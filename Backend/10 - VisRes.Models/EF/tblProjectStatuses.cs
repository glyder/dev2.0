using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectStatuses
    {
        [Key]
        public int ProjectStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
