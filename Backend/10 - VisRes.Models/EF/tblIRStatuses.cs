﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIRStatuses
    {
        public tblIRStatuses()
        {
            tblCompanyOnboardingIRStatuses = new HashSet<tblCompanyOnboardingIRStatuses>();
        }

        [Key]
        public int IRStatusID { get; set; }
        [Required]
        [StringLength(120)]
        public string Status { get; set; }
        [StringLength(120)]
        public string Code { get; set; }
        [StringLength(120)]
        public string DisplayName { get; set; }

        [InverseProperty("IRStatus")]
        public ICollection<tblCompanyOnboardingIRStatuses> tblCompanyOnboardingIRStatuses { get; set; }
    }
}
