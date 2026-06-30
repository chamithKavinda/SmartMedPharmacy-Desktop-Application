using MySql.Data.MySqlClient;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;

namespace SmartMedPharmacy.Repository
{
    public class TrackOrderRepository
    {
        private string connectionString =
             "Server=localhost;Database=SmartMedPharmacy;Uid=root;Pwd=CK13;";

        // ---------------- Get Customer Orders History ----------------
        public List<Order> GetCustomerOrders(string mobile)
        {
            List<Order> orders = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Orders WHERE CustomerMobile=@mobile ORDER BY OrderDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@mobile", mobile);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderId = Convert.ToInt32(reader["OrderId"]),

                        CustomerMobile = reader["CustomerMobile"].ToString(),

                        OrderDate =
                        Convert.ToDateTime(reader["OrderDate"]),

                        DeliveryType = reader["DeliveryType"].ToString(),

                        DeliveryAddress = reader["DeliveryAddress"].ToString(),

                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),

                        Status = reader["Status"].ToString()
                    });
                }
            }
            return orders;
        }

        // ---------------- Delete Orders ----------------
        public bool CancelOrder(int orderId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Orders SET Status='Cancelled' WHERE OrderId=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue( "@id", orderId);

                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
        }
    }
}