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
            if (!ValidateMobile(mobile))
            {
                return null;
            }
            return repository.GetCustomerOrders(mobile);
        }

        public bool CancelOrder(int orderId)
        {
            if (orderId <= 0)
            {
                return false;
            }
            return repository.CancelOrder(orderId);
        }

        private bool ValidateMobile(string mobile)
        {
            if (string.IsNullOrWhiteSpace(mobile))
                return false;

            if (mobile.Length != 10)
                return false;

            if (!long.TryParse(mobile, out _))
                return false;

            return true;
        }
    }
}