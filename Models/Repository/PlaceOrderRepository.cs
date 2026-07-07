using MySql.Data.MySqlClient;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;

namespace SmartMedPharmacy.Repository
{
    public class PlaceOrderRepository
    {
        private string connectionString =
            "Server=localhost;Database=SmartMedPharmacy;Uid=root;Pwd=CK13;";

        // ---------------- Confirm Order ----------------
        public bool SaveOrder(Order order)
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlTransaction transaction =
                    conn.BeginTransaction();

                try
                {
                    string orderQuery =
                    @"INSERT INTO Orders
                    (CustomerMobile, OrderDate, DeliveryType,
                     DeliveryAddress, TotalAmount, Status)

                    VALUES
                    (@mobile,@date,@delivery,
                     @address,@total,@status);

                    SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd =
                        new MySqlCommand(orderQuery, conn, transaction);

                    cmd.Parameters.AddWithValue("@mobile",
                        order.CustomerMobile);

                    cmd.Parameters.AddWithValue("@date",
                        order.OrderDate);

                    cmd.Parameters.AddWithValue("@delivery",
                        order.DeliveryType);

                    cmd.Parameters.AddWithValue("@address",
                        order.DeliveryAddress);

                    cmd.Parameters.AddWithValue("@total",
                        order.TotalAmount);

                    cmd.Parameters.AddWithValue("@status",
                        order.Status);

                    int orderId =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (var item in order.Items)
                    {
                        string itemQuery =
                        @"INSERT INTO OrderItems
                          (OrderId, MedicineId, Quantity, Price)

                          VALUES
                          (@orderId,@medicineId,@qty,@price)";

                        MySqlCommand itemCmd =
                            new MySqlCommand(itemQuery,
                            conn, transaction);

                        itemCmd.Parameters.AddWithValue(
                            "@orderId", orderId);

                        itemCmd.Parameters.AddWithValue(
                            "@medicineId", item.MedicineId);

                        itemCmd.Parameters.AddWithValue(
                            "@qty", item.Quantity);

                        itemCmd.Parameters.AddWithValue(
                            "@price", item.Price);

                        itemCmd.ExecuteNonQuery();


                        string stockQuery =
                        @"UPDATE Medicines
                          SET Stock = Stock - @qty
                          WHERE MedicineId = @medicineId";

                        MySqlCommand stockCmd =
                            new MySqlCommand(stockQuery,
                            conn, transaction);

                        stockCmd.Parameters.AddWithValue(
                            "@qty", item.Quantity);

                        stockCmd.Parameters.AddWithValue(
                            "@medicineId", item.MedicineId);

                        stockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    transaction.Rollback();

                    return false;
                }
            }
        }
    }
}