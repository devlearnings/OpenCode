using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestDemo
{
    public class BaseData
    {
        public static IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString); 
    }
}
