using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VisRes.Models.ViewModels
{
    public class InsuranceTypeNumberExpiredViewModel
    {
        [Key]
        public string InsuranceType { get; set; }

        public int NumberExpired { get; set; }
    }
}
