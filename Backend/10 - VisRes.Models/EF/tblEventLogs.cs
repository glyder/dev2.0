using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisRes.Models.EF
{
    public partial class tblEventLogs
    {
        [Key]
        public int EventLogID { get; set; }
        public int ID { get; set; }
        [StringLength(50)]
        public string PageName { get; set; }
        [Required]
        [StringLength(30)]
        public string FieldGroup { get; set; }
        [StringLength(120)]
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        [StringLength(50)]
        public string Action { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
    }
}
