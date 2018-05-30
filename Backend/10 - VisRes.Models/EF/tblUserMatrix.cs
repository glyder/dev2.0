using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblUserMatrix
    {
        [Key]
        public byte UserMatrixID { get; set; }
        [Required]
        [StringLength(255)]
        public string Function { get; set; }
        [Column("System Administrator")]
        public bool? System_Administrator { get; set; }
        [Column("Regional Administrator")]
        public bool? Regional_Administrator { get; set; }
        [Column("Project Manager")]
        public bool? Project_Manager { get; set; }
        [Column("Project Administrator")]
        public bool? Project_Administrator { get; set; }
        [Column("Project User")]
        public bool? Project_User { get; set; }
        [Column("Company Manager")]
        public bool? Company_Manager { get; set; }
        [Column("Company Administrator")]
        public bool? Company_Administrator { get; set; }
        [StringLength(120)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public bool? EOS { get; set; }
        [Column("National Administrator")]
        public bool? National_Administrator { get; set; }
    }
}
