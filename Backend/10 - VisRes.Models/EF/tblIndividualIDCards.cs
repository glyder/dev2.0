using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualIDCards
    {
        [Key]
        public int IndividalIDCardID { get; set; }
        public int? IndividualID { get; set; }
        [StringLength(120)]
        public string UserName { get; set; }
        public int? CompanyID { get; set; }
        public int? ProjectID { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("tblIndividualIDCards")]
        public tblCompanies Company { get; set; }
        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualIDCards")]
        public tblIndividuals Individual { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblIndividualIDCards")]
        public tblProjects Project { get; set; }
    }
}
