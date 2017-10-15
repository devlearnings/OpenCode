using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace WinFormMVCDemo
{
    public static class SqlDbConnection
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);

        public static class ConnectionString
        {
            public static string Connection = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }
    }
}
