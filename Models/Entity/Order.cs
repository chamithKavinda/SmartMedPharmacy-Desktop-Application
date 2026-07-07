using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMedPharmacy.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustomerMobile { get; set; }

        public DateTime OrderDate { get; set; }

        public string DeliveryType { get; set; }

        public string DeliveryAddress { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
