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
        //public List<Order> GetCustomerOrders(string mobile)
        //{
        //    List<Order> orders = new List<Order>();

        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        string query = @"SELECT * FROM Orders WHERE CustomerMobile=@mobile ORDER BY OrderDate DESC";

        //        MySqlCommand cmd = new MySqlCommand(query, conn);

        //        cmd.Parameters.AddWithValue("@mobile", mobile);

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            orders.Add(new Order
        //            {
        //                OrderId = Convert.ToInt32(reader["OrderId"]),

        //                CustomerMobile = reader["CustomerMobile"].ToString(),

        //                OrderDate =
        //                Convert.ToDateTime(reader["OrderDate"]),

        //                DeliveryType = reader["DeliveryType"].ToString(),

        //                DeliveryAddress = reader["DeliveryAddress"].ToString(),

        //                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),

        //                Status = reader["Status"].ToString(),

        //                Items = new List<OrderItem>()
        //            });
        //        }
        //    }
        //    return orders;
        //}

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
                        OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                        DeliveryType = reader["DeliveryType"].ToString(),
                        DeliveryAddress = reader["DeliveryAddress"].ToString(),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        Status = reader["Status"].ToString(),

                        Items = new List<OrderItem>()
                    });
                }

                reader.Close();

                foreach (Order order in orders)
                {
                    string itemQuery = @"SELECT oi.*, m.Name FROM OrderItems oi INNER JOIN Medicines m ON oi.MedicineId = m.MedicineId WHERE oi.OrderId=@orderId";

                    MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn);

                    itemCmd.Parameters.AddWithValue("@orderId", order.OrderId);

                    MySqlDataReader itemReader = itemCmd.ExecuteReader();

                    while (itemReader.Read())
                    {
                        order.Items.Add(new OrderItem
                        {
                            OrderId = order.OrderId,
                            MedicineId = Convert.ToInt32(itemReader["MedicineId"]),
                            MedicineName = itemReader["Name"].ToString(),
                            Quantity = Convert.ToInt32(itemReader["Quantity"]),
                            Price = Convert.ToDecimal(itemReader["Price"])
                        });
                    }

                    itemReader.Close();
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