using SmartMedPharmacy.Models;
using SmartMedPharmacy.Repository;

namespace SmartMedPharmacy.Controller
{
    public class PlaceOrderController
    {
        private PlaceOrderRepository repository = new PlaceOrderRepository();

        public bool PlaceOrder(Order order)
        {
            if (!ValidateOrder(order))
            {
                return false;
            }
            return repository.SaveOrder(order);
        }

        private bool ValidateOrder(Order order)
        {
            if (string.IsNullOrEmpty(order.CustomerMobile))
            {
                return false;
            }

            if (order.CustomerMobile.Length != 10)
            {
                return false;
            }

            if (string.IsNullOrEmpty(order.DeliveryType))
            {
                return false;
            }

            if (order.DeliveryType == "Delivery" &&
                string.IsNullOrEmpty(order.DeliveryAddress))
            {
                return false;
            }

            if (order.TotalAmount <= 0)
            {
                return false;
            }

            if (order.Items == null || order.Items.Count == 0)
            {
                return false;
            }

            foreach (var item in order.Items)
            {
                if (item.MedicineId <= 0)
                {
                    return false;
                }

                if (item.Quantity <= 0)
                {
                    return false;
                }

                if (item.Price <= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}