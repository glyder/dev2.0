using System.ComponentModel.DataAnnotations;

// TODO: GP, Change Vrs.Models.EF to Vrs.Models.ViewModel but throwing weird error. Sort later
namespace VisRes.Models.EF
{
    public partial class CompanyExpiredInsurancesViewModel
    {
        [Key]
        public string InsuranceType { get; set; }

        public int NumberExpired { get; set; }
    }
}