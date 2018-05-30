using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace VisRes.Models.EF
{
    [JsonObject(MemberSerialization.OptIn)]
    public interface ITblDivision
    {
        [JsonProperty]
        int DivisionID { get; set; }

        [JsonProperty]
        string Name { get; set; }

        [JsonProperty]
        string Description { get; set; }

        [IgnoreDataMember]
        int? BrandingID { get; set; }
    }
}
