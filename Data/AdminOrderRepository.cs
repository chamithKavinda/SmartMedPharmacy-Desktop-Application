using MySql.Data.MySqlClient;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;

namespace SmartMedPharmacy.Repository
{
    public class AdminOrderRepository
    {
        private string connectionString =
            "Server=localhost;Database=SmartMedPharmacy;Uid=root;Pwd=CK13;";

        // ---------------- Get All Orders ----------------
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Orders ORDER BY OrderDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderId = Convert.ToInt32(reader["OrderId"]),
                        CustomerMobile = reader["CustomerMobile"].ToString(),
                        OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                        DeliveryType = reader["DeliveryType"].ToString(),
                        DeliveryAddress = reader["DeliveryAddress"].ToString(),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        Status = reader["Status"].ToString()
                    });
                }
            }

            return orders;
        }

        // ---------------- Update Admin Order ----------------
        public bool UpdateOrderStatus(int orderId, string status)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Orders SET Status=@status WHERE OrderId=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", orderId);

                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
        }

        // ---------------- Delete Order ----------------
        public bool DeleteOrder(int orderId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Orders WHERE OrderId=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", orderId);

                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
        }

        // ---------------- Search Order ----------------
        public List<Order> SearchOrder(string keyword)
        {
            List<Order> orders = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Orders 
                         WHERE OrderId LIKE @keyword 
                            OR CustomerMobile LIKE @keyword 
                            OR DeliveryType LIKE @keyword 
                            OR DeliveryAddress LIKE @keyword 
                            OR Status LIKE @keyword 
                         ORDER BY OrderDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderId = Convert.ToInt32(reader["OrderId"]),
                        CustomerMobile = reader["CustomerMobile"].ToString(),
                        OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                        DeliveryType = reader["DeliveryType"].ToString(),
                        DeliveryAddress = reader["DeliveryAddress"].ToString(),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        Status = reader["Status"].ToString()
                    });
                }
            }
            return orders;
        }
    }
}