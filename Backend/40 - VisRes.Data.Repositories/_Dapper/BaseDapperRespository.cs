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
    public class BaseDapperRespository
    {
        public string connectionString;

        // TODO: GP - WILL REFACTOR THIS!!! Need something that works first
        public BaseDapperRespository()
        {
            // connectionString = @"Server=localhost;Database=DapperDemo;Trusted_Connection=true;";
            connectionString = @"Data Source=TST-VM-VRSQL1;Initial Catalog=VisRes2;User ID=VisResWeb;Password=Sayvn1Derz03:23";
            // connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=VisRes2;Integrated Security=True;MultipleActiveResultSets=True";
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(this.connectionString);
        }

    }
}
