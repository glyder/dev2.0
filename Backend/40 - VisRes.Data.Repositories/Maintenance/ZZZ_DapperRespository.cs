using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using VisRes.Models.EF;

using Dapper;
using Dapper.Fluent;
using System.Threading.Tasks;
using VisRes.Models.ViewModels;

namespace VisRes.Data.Repositories
{
    // ==================================================================
    // https://github.com/StackExchange/Dapper
    // http://www.talkingdotnet.com/use-dapper-orm-with-asp-net-core/
    // ==================================================================

    public class DapperRespository : BaseDapperRespository
    {
        // STORED PROCEDURE COPY THIS
        public async Task<IEnumerable<InsuranceTypeNumberExpiredViewModel>> GetCompanyExpiredInsurancesViewModel(int? lobID = null,
                                                                                                                 int? projectID = null,
                                                                                                                 int? companyID = null)
                                                                                                                ///string model)
        {
            IEnumerable<InsuranceTypeNumberExpiredViewModel> expiredInsurances;

            using (var conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();

                expiredInsurances = await conn.QueryAsync<InsuranceTypeNumberExpiredViewModel>
                                                        ("Dashboard_ExpiredItems_Company",
                                                        new { lobID, projectID, companyID },        // TODO: need to test this. 
                                                        commandType: CommandType.StoredProcedure);


                //===========================================
                //result is list of CustomTest
                //var result = conn.Query<InsuranceTypeNumberExpiredViewModel>
                //                       ("Dashboard_ExpiredItems_Company", 
                //                       //new { RequestId },
                //                       commandType: CommandType.StoredProcedure);

                //===========================================
                //var result = conn.Query<CustomTest>("exec [dbo].[GetRequestTest] @id", new { Id = RequestId });
                //

                //===========================================
                //var p = new DynamicParameters();
                //p.Add("@a", 11);
                //p.Add("@b", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //p.Add("@c", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
                //cnn.Execute("spMagicProc", p, commandType: CommandType.StoredProcedure);
                //int b = p.Get<int>("@b");
                //int c = p.Get<int>("@c");
                //DECLARE @output int
                //EXEC < some stored proc> @i = @output OUTPUT
                // SELECT @output AS output1

                //===========================================
                //var shapes = new List<IShape>();
                //using (var reader = connection.ExecuteReader("select * from Shapes"))
                //{
                //    // Gen



            }
            return expiredInsurances;
        }


        public void Add(tblLOBs lobs)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "INSERT INTO tblLOBs(LOB, FromDate, EditedBy,DivisionID)"
                                          + " VALUES(@LOB, '2012-02-14 22:26:05.157', 'GP',1)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, lobs);
            }
        }

        public IEnumerable<tblLOBs> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<tblLOBs>("SELECT * FROM tblLOBs");
            }
        }

        public tblLOBs GetByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "SELECT * FROM tblLOBs"
                                     + " WHERE LOBID = @Id";
                dbConnection.Open();
                return dbConnection.Query<tblLOBs>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery =  "DELETE FROM Products"
                              + " WHERE ProductId = @Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }

        public void Update(tblLOBs prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "UPDATE Products SET Name = @Name,"
                                                 + " Quantity = @Quantity, Price= @Price"
                             + " WHERE ProductId = @ProductId";
                dbConnection.Open();
                dbConnection.Query(sQuery, prod);
            }
        }
    }
}
