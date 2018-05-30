using System.Linq;
using System.Collections.Generic;

using VisRes.Data.EFCore;

using VisRes.Models.EF;

namespace VisRes.Data.Repositories
{
    // TODO: GP: move this back to IRespository or to interface. Waiting to see which is best structure.
    public interface ICompaniesRepository : IEFCoreBaseRepository<tblCompanies>
    {
        IEnumerable<tblInsuranceTypes> PopulateInsuranceTypesDropdownList();
    }

    public class CompaniesRepository : EFCoreBaseRepository<tblCompanies>, ICompaniesRepository
    {
        private VrsContext _context;

        public CompaniesRepository(VrsContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<tblInsuranceTypes> PopulateInsuranceTypesDropdownList()
        {
            return _context.tblInsuranceTypes.OrderBy(d => d.Type);
        }
    }
}

