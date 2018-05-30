using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblStates
    {
        public tblStates()
        {
            tblAddresses = new HashSet<tblAddresses>();
        }

        [Key]
        public int StateID { get; set; }
        [Required]
        [StringLength(255)]
        public string State { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        [InverseProperty("tblStates")]
        public tblCountries Country { get; set; }
        [InverseProperty("State")]
        public ICollection<tblAddresses> tblAddresses { get; set; }
    }
}
