using SmartMedPharmacy.Models;
using SmartMedPharmacy.Repository;
using System;
using System.Collections.Generic;

namespace SmartMedPharmacy.Controller
{
    public class AdminOrderController
    {
        private AdminOrderRepository repository = new AdminOrderRepository();

        public List<Order> GetOrders()
        {
            return repository.GetAllOrders();
        }

        public bool UpdateStatus(int id, string status)
        {
            return repository.UpdateOrderStatus(id, status);
        }

        public bool DeleteOrder(int id)
        {
            return repository.DeleteOrder(id);
        }

        public List<Order> SearchOrders(string keyword)
        {
            return repository.SearchOrder(keyword);
        }
        public Tuple<string, string> GetCustomerDetails(string customerMobile)
        {
            return repository.GetCustomerDetails(customerMobile);
        }

        public List<string> GetOrderMedicines(int orderId)
        {
            return repository.GetOrderMedicines(orderId);
        }
    }
}