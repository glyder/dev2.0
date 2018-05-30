using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblContractProjects
    {
        [Key]
        public int ContractProjectID { get; set; }
        public int ContractID { get; set; }
        public int ProjectID { get; set; }
        public string Comment { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("ContractID")]
        [InverseProperty("tblContractProjects")]
        public tblContracts Contract { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblContractProjects")]
        public tblProjects Project { get; set; }
    }
}
