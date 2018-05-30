using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblSHEQStatuses
    {
        public tblSHEQStatuses()
        {
            tblCompanyOnboardingSHEQStatuses = new HashSet<tblCompanyOnboardingSHEQStatuses>();
        }

        [Key]
        public int SHEQStatusID { get; set; }
        [Required]
        [StringLength(120)]
        public string Status { get; set; }
        [StringLength(120)]
        public string Code { get; set; }
        [StringLength(120)]
        public string DisplayName { get; set; }

        [InverseProperty("SHEQStatus")]
        public ICollection<tblCompanyOnboardingSHEQStatuses> tblCompanyOnboardingSHEQStatuses { get; set; }
    }
}
