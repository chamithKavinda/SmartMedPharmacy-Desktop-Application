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

                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string deleteItemsQuery = "DELETE FROM OrderItems WHERE OrderId = @id";
                        using (MySqlCommand cmdItems = new MySqlCommand(deleteItemsQuery, conn, transaction))
                        {
                            cmdItems.Parameters.AddWithValue("@id", orderId);
                            cmdItems.ExecuteNonQuery();
                        }

                        string deleteOrderQuery = "DELETE FROM Orders WHERE OrderId = @id";
                        using (MySqlCommand cmdOrder = new MySqlCommand(deleteOrderQuery, conn, transaction))
                        {
                            cmdOrder.Parameters.AddWithValue("@id", orderId);
                            int rows = cmdOrder.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                transaction.Commit();
                                return true;
                            }
                        }

                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
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

        // ---------------- Get Customer Email and Address ----------------
        public Tuple<string, string> GetCustomerDetails(string customerMobile)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Email, Address FROM Users WHERE MobileNumber = @mobile LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mobile", customerMobile);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string email = reader["Email"]?.ToString() ?? string.Empty;
                        string address = reader["Address"]?.ToString() ?? string.Empty;
                        return Tuple.Create(email, address);
                    }
                }
            }
            return Tuple.Create(string.Empty, string.Empty);
        }

        // ---------------- Get Medicines with Quantity for Order ----------------
        public List<string> GetOrderMedicines(int orderId)
        {
            List<string> medicines = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT m.Name, oi.Quantity 
                         FROM OrderItems oi 
                         INNER JOIN Medicines m ON oi.MedicineId = m.MedicineId 
                         WHERE oi.OrderId = @orderId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string qty = reader["Quantity"].ToString();
                        medicines.Add($"{name} x{qty}");
                    }
                }
            }
            return medicines;
        }

        // ---------------- Get New Orders count for Admin Dashboard ----------------
        public int GetNewOrdersCount()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT COUNT(*) 
                         FROM Orders 
                         WHERE Status <> 'Delivered'";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // ---------------- Get Today Revenue Amount for Admin Dashboard ----------------
        public decimal GetTodaysRevenue()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT IFNULL(SUM(TotalAmount),0)
                         FROM Orders
                         WHERE DATE(OrderDate)=CURDATE()
                         AND Status='Delivered'";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        // ---------------- Get Today Revenue Amount for Admin Dashboard ----------------
        public int GetLowStockCount()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT COUNT(*)
                         FROM Medicines
                         WHERE Stock <= 10";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }


}