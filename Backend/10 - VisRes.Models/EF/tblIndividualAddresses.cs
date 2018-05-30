using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblIndividualAddresses
    {
        [Key]
        public int IndividualAddressID { get; set; }
        public int IndividualID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Required]
        [StringLength(150)]
        public string EditedBy { get; set; }

        [ForeignKey("AddressID")]
        [InverseProperty("tblIndividualAddresses")]
        public tblAddresses Address { get; set; }
        [ForeignKey("AddressTypeID")]
        [InverseProperty("tblIndividualAddresses")]
        public tblAddressTypes AddressType { get; set; }
        [ForeignKey("IndividualID")]
        [InverseProperty("tblIndividualAddresses")]
        public tblIndividuals Individual { get; set; }
    }
}
