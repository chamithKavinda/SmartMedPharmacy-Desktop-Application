using System.Configuration;
using MySql.Data.MySqlClient;

namespace SmartMedPharmacy.Data
{
    public static class DatabaseConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SmartMedDB"].ConnectionString;

            return new MySqlConnection(connectionString);
        }
    }
}