using NPoco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisRes.Data.AncientSqlClient
{
    public class DataAccess : IDataAccess
    {
        string ConnStr;
        string Error;
        string Version;

        public DataAccess(string cs)
        {
            ConnStr = cs;
        }

        public bool TestOpen()
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    Version = "SQL SERVER: " + conn.ServerVersion + " " + conn.State;
                    IDatabase db = new Database(conn);
                    var list = db.Query<string>("select companyname from tblcompanydetails order by companyid OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY");
                    Version = "SQL SERVER " + conn.ServerVersion + " : " + conn.State + " :  Offset/Fetch = " + list.Count();
                    return true;
                }
                catch (Exception e)
                {
                    LogError(e.Message);
                    return false;
                }
            }
        }

        public IEnumerable<T> Query<T>(string sql, params object[] arguments)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    IDatabase db = new Database(conn);
                    IEnumerable<T> users = db.Fetch<T>(sql, arguments);
                    return users;
                }
                catch (Exception e)
                {
                    LogError(e.Message);
                    throw;
                }
            }
        }

        public void Update<T>(string sql, params object[] arguments)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    IDatabase db = new Database(conn);
                    db.Execute(sql, arguments);
                    return;
                }
                catch (Exception e)
                {
                    LogError(e.Message);
                    throw;
                }
            }
        }

        public int ExecuteScalar(string sql, params object[] arguments)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    IDatabase db = new Database(conn);
                    var count = db.ExecuteScalar<int>(sql, arguments);
                    return count;
                }
                catch (Exception e)
                {
                    LogError(e.Message);
                    return 0;
                }
            }
        }

        public Page<T> FetchPage<T>(int page, int items, string sql)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    IDatabase db = new Database(conn);
                    var res = db.Page<T>(page, items, sql);
                    return res;
                }
                catch (Exception e)
                {
                    LogError(e.Message);
                    return null;
                }

            }
        }

        public void LogError(string error)
        {
            Error = error;
        }
        public string GetError()
        {
            return Error;
        }

        public string GetVersion()
        {
            return Version;
        }
    }
}
