using SmartMedPharmacy.Models;
using SmartMedPharmacy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SmartMedPharmacy.Controller
{
    public class AdminOrderController
    {
        private AdminOrderRepository repository = new AdminOrderRepository();

        public List<Order> GetOrders()
        {
            return repository.GetAllOrders();
        }

        // ---------------- Update Order ----------------
        public bool UpdateStatus(int id, string status)
        {
            // Validation
            if (id <= 0)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                return false;
            }

            string[] validStatuses =
            {
                "Pending",
                "Ready for Pickup",
                "Delivered",
                "Cancelled"
            };

            if (!validStatuses.Contains(status))
            {
                return false;
            }

            return repository.UpdateOrderStatus(id, status);
        }

        // ---------------- Delete Order ----------------
        public bool DeleteOrder(int id)
        {
            if (id <= 0)
            {
                return false;
            }

            return repository.DeleteOrder(id);
        }


        // ---------------- Find Order ----------------
        public List<Order> SearchOrders(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return new List<Order>();
            }

            return repository.SearchOrder(keyword.Trim());
        }

        // ---------------- Load Customer Data ----------------
        public Tuple<string, string> GetCustomerDetails(string customerMobile)
        {
            if (string.IsNullOrWhiteSpace(customerMobile))
            {
                return null;
            }

            if (!Regex.IsMatch(customerMobile, @"^\d{10}$"))
            {
                return null;
            }
            return repository.GetCustomerDetails(customerMobile);
        }

        // ---------------- load Medicine belong to the OrderId ----------------
        public List<string> GetOrderMedicines(int orderId)
        {
            if (orderId <= 0)
            {
                return new List<string>();
            }

            return repository.GetOrderMedicines(orderId);
        }

        // Dashboard Statistics
        public int GetNewOrdersCount()
        {
            return repository.GetNewOrdersCount();
        }

        public decimal GetTodaysRevenue()
        {
            return repository.GetTodaysRevenue();
        }

        public int GetLowStockCount()
        {
            return repository.GetLowStockCount();
        }
    }
}