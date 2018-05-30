using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblOperStatuses
    {
        public tblOperStatuses()
        {
            tblCompanyOnboardingOperStatuses = new HashSet<tblCompanyOnboardingOperStatuses>();
        }

        [Key]
        public int OperStatusID { get; set; }
        [Required]
        [StringLength(120)]
        public string Status { get; set; }
        [StringLength(120)]
        public string Code { get; set; }
        [StringLength(120)]
        public string DisplayName { get; set; }

        [InverseProperty("OperStatus")]
        public ICollection<tblCompanyOnboardingOperStatuses> tblCompanyOnboardingOperStatuses { get; set; }
    }
}
