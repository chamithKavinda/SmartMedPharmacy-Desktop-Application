using SmartMedPharmacy.Models;
using SmartMedPharmacy.Repository;

namespace SmartMedPharmacy.Controller
{
    public class PlaceOrderController
    {
        private PlaceOrderRepository repository =
            new PlaceOrderRepository();

        public bool PlaceOrder(Order order)
        {
            return repository.SaveOrder(order);
        }
    }
}