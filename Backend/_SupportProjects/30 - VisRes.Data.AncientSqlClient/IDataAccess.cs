using System.Collections.Generic;

using NPoco;

namespace VisRes.Data.AncientSqlClient
{
    public interface IDataAccess
    {
        IEnumerable<T> Query<T>(string sql, params object[] arguments);
        bool TestOpen();
        int ExecuteScalar(string sql, params object[] arguments);
        Page<T> FetchPage<T>(int page, int items, string sql);           //Page<T> from NPoco
        string GetError();
        string GetVersion();

        void Update<T>(string sql, params object[] arguments);

    }
}
