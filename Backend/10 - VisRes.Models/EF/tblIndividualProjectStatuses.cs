using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualProjectStatuses
    {
        public tblIndividualProjectStatuses()
        {
            tblIndividualProjects = new HashSet<tblIndividualProjects>();
        }

        [Key]
        public int IndividualProjectStatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IndividualProjectStatus")]
        public ICollection<tblIndividualProjects> tblIndividualProjects { get; set; }
    }
}
