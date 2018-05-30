
using VisRes.Models.EF;
using VisRes.Data.EFCore;

namespace VisRes.Data.Repositories
{
    public interface IInsuranceTypesRepository : IEFCoreBaseRepository<tblInsuranceTypes> {


    }

    public class InsuranceTypesRepository : EFCoreBaseRepository<tblInsuranceTypes>, IInsuranceTypesRepository
    {
        private VrsContext _context;

        public InsuranceTypesRepository(VrsContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
