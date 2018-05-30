using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisRes.Models.EF;

namespace VisRes.Models.ViewModels
{
    public class CompanyViewModel
    {
        int CompanyID { get; set; }
        public string CompanyName { get; set; }

        List<tblContracts> ContractList { get; set; }
    }
}
