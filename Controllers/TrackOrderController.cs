using SmartMedPharmacy.Models;
using SmartMedPharmacy.Repository;
using System.Collections.Generic;

namespace SmartMedPharmacy.Controller
{
    public class TrackOrderController
    {
        private TrackOrderRepository repository = new TrackOrderRepository();

        public List<Order> GetOrders(string mobile)
        {
            return repository.GetCustomerOrders(mobile);
        }

        public bool CancelOrder(int orderId)
        {
            return repository.CancelOrder(orderId);
        }
    }
}