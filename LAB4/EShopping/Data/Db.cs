using System.Configuration;
using System.Data.SqlClient;

namespace EShopping.Data
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["EShoppingDB"].ConnectionString);
        }
    }
}
