using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblProjectAddresses
    {
        [Key]
        public int ProjectAddressID { get; set; }
        public int ProjectID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("AddressID")]
        [InverseProperty("tblProjectAddresses")]
        public tblAddresses Address { get; set; }
        [ForeignKey("AddressTypeID")]
        [InverseProperty("tblProjectAddresses")]
        public tblAddressTypes AddressType { get; set; }
        [ForeignKey("ProjectID")]
        [InverseProperty("tblProjectAddresses")]
        public tblProjects Project { get; set; }
    }
}
