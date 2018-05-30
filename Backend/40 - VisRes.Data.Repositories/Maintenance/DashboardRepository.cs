using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using VisRes.Models.EF;

using Dapper;
using Dapper.Fluent;
using System.Threading.Tasks;

namespace VisRes.Data.Repositories
{
    public class DashboardRespository : BaseDapperRespository
    {
        public DashboardRespository()
        {
        }

        public async Task<IEnumerable<CompanyExpiredInsurancesViewModel>> GetCompanyExpiredInsurancesViewModel(string model)
        {
            IEnumerable<CompanyExpiredInsurancesViewModel> expiredInsurances;

            using (var conn = base.GetSqlConnection())
            {
                await conn.OpenAsync();

                expiredInsurances = await conn.QueryAsync<CompanyExpiredInsurancesViewModel>
                                                        ("Dashboard_ExpiredItems_Company",
                                                        // new { Model = model },
                                                        commandType: CommandType.StoredProcedure);
            }
            return expiredInsurances;
        }
    }
}
