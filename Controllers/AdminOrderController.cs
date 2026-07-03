using SmartMedPharmacy.Repository;
using SmartMedPharmacy.Models;
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
    }
}