using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SmartMedPharmacy.Repository
{
    public class ReportRepository
    {
        private string connectionString =
            "Server=localhost;Database=SmartMedPharmacy;Uid=root;Pwd=CK13;";

        // Sales Report
        public DataTable GetSalesReport(DateTime from, DateTime to)
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT OrderId,
                                        CustomerMobile,
                                        OrderDate,
                                        TotalAmount,
                                        Status
                                 FROM Orders
                                 WHERE OrderDate BETWEEN @from AND @to
                                 ORDER BY OrderDate DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                adapter.SelectCommand.Parameters.AddWithValue("@from", from);
                adapter.SelectCommand.Parameters.AddWithValue("@to", to);

                adapter.Fill(table);
            }

            return table;
        }

        // Stock Report
        public DataTable GetStockReport()
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT
                                MedicineId,
                                Name,
                                Category,
                                Supplier,
                                Stock,
                                Price,
                                ExpiryDate
                                FROM Medicines";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                adapter.Fill(table);
            }

            return table;
        }

        // Order History
        public DataTable GetDeliveredOrders()
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT OrderId,
                                CustomerMobile,
                                OrderDate,
                                DeliveryType,
                                DeliveryAddress,
                                TotalAmount,
                                Status
                         FROM Orders
                         WHERE Status = 'Delivered'
                         ORDER BY OrderDate DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(table);
            }

            return table;
        }

        public decimal GetTotalSales(DateTime from, DateTime to)
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT IFNULL(SUM(TotalAmount),0)
                  FROM Orders
                  WHERE OrderDate BETWEEN @from AND @to";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public int GetTotalOrders(DateTime from, DateTime to)
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT COUNT(*)
                  FROM Orders
                  WHERE OrderDate BETWEEN @from AND @to";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalStock()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT SUM(Stock) FROM Medicines";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}